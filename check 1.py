import csv
import os
import asyncio
import aiofiles
from fastapi import APIRouter, File, UploadFile, HTTPException, Form
from ..dependencies import cache_file_path
from ..services.openai_service import call_openai

router = APIRouter()


# @router.post("/response_openai_3-5/{factor_name}")
async def response_openai(
    factor_name: str,
    model: str,
    pasted_code: str = Form(default=None),
    codefile: UploadFile = File(default=None),
    temperature: float = 0.9,
):

    if model != "gpt-3.5-turbo-0125" and model != "gpt-4-turbo-preview":
        raise HTTPException(
            status_code=404,
            detail="Model not found. Please provide a valid model name.",
        )

    if not 0.0 < temperature < 2.0:
        raise HTTPException(
            status_code=400,
            detail="Invalid temperature value. Temperature should be in the range 0 to 2.",
        )

    code_content = None

    try:
        if codefile:
            # Async read of the uploaded file content
            code_content = await codefile.read()
            code_content = code_content.decode("utf-8")
        elif (
            pasted_code and pasted_code.strip()
        ):  # If codefile is not uploaded but pasted_code is present and not empty
            code_content = pasted_code.strip()
    except Exception as e:
        raise HTTPException(
            status_code=500, detail=f"Error reading file or pasted_code: {str(e)}"
        )

    filename = factor_name + ".csv"
    folder_name = "csvs"
    csv_file_path = os.path.join(folder_name, filename)

    prompts_dict = {}

    try:
        with open(csv_file_path, "r") as csvfile:
            reader = csv.reader(csvfile)
            for row in reader:
                if row:
                    key, value = row
                    prompts_dict[key] = value
    except FileNotFoundError:
        raise HTTPException(status_code=404, detail="CSV file not found.")
    except Exception as e:
        raise HTTPException(status_code=500, detail=f"Error reading CSV file: {str(e)}")

    try:
        tasks = [
            call_openai(index, characteristic, prompt, code_content, model, temperature)
            for index, (characteristic, prompt) in enumerate(prompts_dict.items())
        ]
        responses = await asyncio.gather(*tasks)
    except Exception as e:
        raise HTTPException(
            status_code=500, detail=f"Error calling the model API: {str(e)}"
        )

    content = "".join(responses)

    # For reading responses from a file locally

    # try:
    #     # Use aiofiles to read the content of cache.md asynchronously
    #     async with aiofiles.open(cache_file_path, mode="r", encoding="utf-8") as file:
    #         content = await file.read()
    # except FileNotFoundError:
    #     raise HTTPException(status_code=404, detail="Cache file not found.")
    # except Exception as e:
    #     raise HTTPException(
    #         status_code=500, detail=f"Error reading cache file: {str(e)}"
    #     )

    return content
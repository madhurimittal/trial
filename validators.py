"""validators.py – tiny helper module (43 lines) to round the demo to 200 LOC."""
import re
from datetime import datetime


class ValidationError(ValueError):
    """Raised when validation fails."""


EMAIL_PATTERN = re.compile(r"^[\w\.-]+@[\w\.-]+\.[a-zA-Z]{2,}$")


def validate_email(address: str) -> str:
    """Return the e-mail if valid, else raise ValidationError."""
    if not EMAIL_PATTERN.fullmatch(address):
        raise ValidationError(f"Invalid email address: {address}")
    return address


def validate_due_date(date_str: str) -> str:
    """Ensure date is ISO-8601 (YYYY-MM-DD) and not past."""
    try:
        dt = datetime.fromisoformat(date_str)
    except ValueError:
        raise ValidationError("Date must be YYYY-MM-DD")

    if dt.date() < datetime.utcnow().date():
        raise ValidationError("Due date cannot be in the past")
    return date_str


def demo() -> None:
    """Quick self-test."""
    cases = [
        ("good@example.com", "2099-01-01"),
        ("bad-address", "2099-01-01"),
        ("good@example.com", "1999-01-01"),
    ]
    for email, due in cases:
        try:
            validate_email(email)
            validate_due_date(due)
            print("OK", email, due)
        except ValidationError as e:
            print("FAIL", e)


if __name__ == "__main__":
    demo()

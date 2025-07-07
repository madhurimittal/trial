"""
tasks_manager.py – lightweight CLI todo app with JSON persistence.
Perfect size for a CodeSherlock demo (157 lines without boilerplate).
"""

from __future__ import annotations

import argparse
import json
import sys
from dataclasses import dataclass, asdict
from datetime import datetime
from pathlib import Path
from typing import List, Optional


@dataclass
class Task:
    """Simple data holder representing a task item."""
    id: int
    title: str
    created_at: str
    due: Optional[str] = None
    done: bool = False

    def to_json(self) -> dict:
        """Convert the task to a JSON-serialisable dict."""
        return asdict(self)

    @classmethod
    def from_json(cls, data: dict) -> "Task":
        """Create a Task instance from a JSON dict."""
        return cls(**data)


class TaskManager:
    """Manage a collection of Task objects with JSON persistence."""

    def __init__(self, store: Path | str = "tasks.json"):
        self.store = Path(store)
        self.tasks: List[Task] = []
        self._next_id = 1
        self._load()

    # ── persistence helpers ─────────────────────────────────────────────
    def _load(self) -> None:
        if self.store.exists():
            try:
                data = json.loads(self.store.read_text())
            except json.JSONDecodeError:
                print("⚠️  Corrupted task store; starting with empty list.", file=sys.stderr)
                data = []
            self.tasks = [Task.from_json(d) for d in data]
            if self.tasks:
                self._next_id = max(t.id for t in self.tasks) + 1

    def _save(self) -> None:
        self.store.write_text(json.dumps([t.to_json() for t in self.tasks], indent=2))

    # ── CRUD operations ─────────────────────────────────────────────────
    def add(self, title: str, due: Optional[str] = None) -> Task:
        task = Task(
            id=self._next_id,
            title=title,
            created_at=datetime.utcnow().isoformat(timespec="seconds"),
            due=due,
        )
        self.tasks.append(task)
        self._next_id += 1
        self._save()
        return task

    def list(self, show_all: bool = True) -> List[Task]:
        return self.tasks if show_all else [t for t in self.tasks if not t.done]

    def complete(self, task_id: int) -> bool:
        for task in self.tasks:
            if task.id == task_id:
                task.done = True
                self._save()
                return True
        return False

    def delete(self, task_id: int) -> bool:
        for i, task in enumerate(self.tasks):
            if task.id == task_id:
                del self.tasks[i]
                self._save()
                return True
        return False

    def summary(self) -> str:
        total = len(self.tasks)
        done = sum(1 for t in self.tasks if t.done)
        return f"Total tasks: {total} | Done: {done} | Pending: {total - done}"


# ── CLI wiring ──────────────────────────────────────────────────────────
def _parse_args(argv: List[str] | None = None) -> argparse.Namespace:
    parser = argparse.ArgumentParser(description="Lightweight CLI todo app.")
    sub = parser.add_subparsers(dest="command", required=True)

    add_p = sub.add_parser("add", help="Add a new task")
    add_p.add_argument("title", help="Task title")
    add_p.add_argument("--due", help="Due date ISO-8601")

    list_p = sub.add_parser("list", help="List tasks")
    list_p.add_argument("--pending-only", action="store_true")

    done_p = sub.add_parser("done", help="Mark a task as complete")
    done_p.add_argument("id", type=int)

    del_p = sub.add_parser("delete", help="Delete a task")
    del_p.add_argument("id", type=int)

    sub.add_parser("summary", help="Show quick stats")

    return parser.parse_args(argv)


def main(argv: List[str] | None = None) -> None:
    args = _parse_args(argv)
    tm = TaskManager()

    if args.command == "add":
        task = tm.add(args.title, args.due)
        print(f"Added task #{task.id}: {task.title}")

    elif args.command == "list":
        tasks = tm.list(show_all=not args.pending_only)
        for t in tasks:
            status = "✓" if t.done else "…"
            print(f"[{status}] {t.id:3d}: {t.title} (due: {t.due or '—'})")

    elif args.command == "done":
        if tm.complete(args.id):
            print(f"Marked task #{args.id} as complete.")
        else:
            print("Task not found.", file=sys.stderr)

    elif args.command == "delete":
        if tm.delete(args.id):
            print(f"Deleted task #{args.id}.")
        else:
            print("Task not found.", file=sys.stderr)

    elif args.command == "summary":
        print(tm.summary())

    else:
        raise RuntimeError("Unhandled command")


if __name__ == "__main__":
    main()

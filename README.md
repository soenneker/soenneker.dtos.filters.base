[![](https://img.shields.io/nuget/v/soenneker.dtos.filters.base.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.base/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.base/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.base/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.filters.base.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.base/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.base/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.base/actions/workflows/codeql.yml)

# Soenneker.Dtos.Filters.Base

Defines the target field shared by structured API query filters.

## Install

```bash
dotnet add package Soenneker.Dtos.Filters.Base
```

## What you get

- `FilterBase` — Defines the target field shared by structured API query filters.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `FilterBase.Field` | Serializable field name to evaluate; supported names are determined by the queried resource. | Serializable field name to evaluate; supported names are determined by the queried resource. |

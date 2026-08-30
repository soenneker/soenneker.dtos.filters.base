[![](https://img.shields.io/nuget/v/soenneker.dtos.filters.base.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.base/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.base/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.base/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.filters.base.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.filters.base/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.filters.base/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.filters.base/actions/workflows/codeql.yml)

# Soenneker.Dtos.Filters.Base

Defines the shared target-field property for structured API filter DTOs.

## Installation

```bash
dotnet add package Soenneker.Dtos.Filters.Base
```

`FilterBase` is abstract. Use a concrete package such as `Soenneker.Dtos.Filters.ExactMatch` or `Soenneker.Dtos.Filters.Range`, or derive an application-specific operator:

```csharp
using System.Text.Json.Serialization;
using Soenneker.Dtos.Filters.Base;

public sealed class ContainsFilter : FilterBase
{
    [JsonPropertyName("value")]
    public string Value { get; set; } = null!;
}

var filter = new ContainsFilter
{
    Field = "displayName",
    Value = "ada"
};
```

`Field` serializes as `field` with both System.Text.Json and Newtonsoft.Json. `FilterBase` is marked with `PublicOpenApiObject` for Soenneker OpenAPI discovery.

The model does not define field aliases, validate that a field exists, select an operator, or execute a query. Treat client-provided field names as untrusted input: map them through a server-owned allow-list of queryable fields and parameterize values. Do not concatenate `Field` into SQL, document-store expressions, or reflection paths.

`Field` is not initialized by the base constructor. Concrete filters and API validators must require it before evaluation.

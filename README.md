# OceanWebSystems.Audit.EntityFramework
**A source generator to generate audit table entities for the Audit.NET framework.**
## Install
**NuGet Package**
To install the package run the following command on the Package Manager Console:
```
PM> Install-Package OceanWebSystems.Audit.EntityFramework
```
[![NuGet Status](https://img.shields.io/nuget/v/OceanWebSystems.Audit.EntityFramework.svg?style=flat)](https://www.nuget.org/packages/OceanWebSystems.Audit.EntityFramework/)
## Usage
The source generator currently only supports the scenario where the audit database context is the same as the "main" context and using OptIn Mode.
Ensure that your `DbContext` class is partial and decorated with the `[AuditConfiguration]` attribute. e.g.
```
using OceanWebSystems.Audit.EntityFramework;

namespace SampleApp.Data.Context
{
  [AuditConfiguration(tableNameSuffix: "Audit")]
  public partial class SampleDbContext : AuditDbContext, ISampleDbContext
  {
    public SampleDbContext()
    {
    }

    public SampleDbContext(DbContextOptions<SampleDbContext> options)
      : base(options)
    {
    }
  }
}
```
The `[AuditConfiguration]` attribute can be used without arguments in which case the suffix for the table name is "AuditRecord".

For each entity that you want to be audited, add the `[AuditInclude]` attribute. e.g.
```
using Audit.EntityFramework;

namespace SampleApp.Data.Models
{
  [AuditInclude]
  public partial class TestModel
  {
    [Key]
    public int Id { get; set; }
    public int LevelId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
  }
} 
```
For the above configuration the following partial `DbContext` and audit entity classes should be generated.
### DbContext
```
// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using SampleApp.Data.Models;

namespace SampleApp.Data.Context
{
  public partial class SampleDbContext
  {
    public virtual DbSet<TestModelAudit> TestModelAudits { get; set; }
  }
}

```
### Audit Entity
```
// <auto-generated />

using System;
using System.ComponentModel.DataAnnotations;
using OceanWebSystems.Audit.EntityFramework;

namespace SampleApp.Data.Models
{
  public partial class TestModelAudit : AuditRecordBase
  {
    [Key]
    public int AuditId { get; set; }

    public int Id { get; set; }

    public int LevelId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
  }
}

```

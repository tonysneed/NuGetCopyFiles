# Copy Files from NuGet Package

Demonstrates how to copy files from a NuGet package to the output directory

> **Reference**: [Copy files from Nuget package to output directory with MsBuild in .csproj and dotnet pack command](https://newbedev.com/copy-files-from-nuget-package-to-output-directory-with-msbuild-in-csproj-and-dotnet-pack-command)

#### NuGetCopyFiles.targets

```xml
<Project>

  <ItemGroup>
    <Files Include="$(MSBuildThisFileDirectory)\..\contentFiles\Files\*.*" />
  </ItemGroup>
  <Target Name="CopyFiles" AfterTargets="Build">
    <Copy SourceFiles="@(Files)" DestinationFolder="$(TargetDir)Files\" />
  </Target>

</Project>
```

#### NuGetCopyFiles.csproj

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <GeneratePackageOnBuild>True</GeneratePackageOnBuild>
    <Authors>Tony Sneed</Authors>
  </PropertyGroup>

  <ItemGroup>
    <Content Include="NuGetCopyFiles.targets" PackagePath="build/NuGetCopyFiles.targets" />
    <Content Include="Files\*.*" Pack="true" PackagePath="contentFiles\Files">
      <PackageCopyToOutput>true</PackageCopyToOutput>
    </Content>
  </ItemGroup>
	
</Project>
```

# NuGet Package via GitHub Actions

Companion repository for the article **How to publish a NuGet package with GitHub Actions in 2026**.

The sample demonstrates a modern package pipeline that:

- derives package versions from Git tags with MinVer;
- caches NuGet packages and repository-local .NET tools;
- verifies formatting and treats build warnings as errors;
- reports test failures through GitHub Actions annotations;
- collects Cobertura coverage with `dotnet-coverage`;
- packs the library once and passes the exact package between jobs;
- publishes releases to NuGet.org with trusted publishing and GitHub OIDC;
- attaches the same `.nupkg` and `.snupkg` files to the GitHub release;
- optionally publishes manually dispatched preview builds to GitHub Packages.

## Publishing

Create a tag such as `v1.0.0`, then publish a GitHub release for that tag. Prerelease tags such as `v1.1.0-preview.1` must be published as GitHub prereleases.

The repository owner must configure a NuGet.org trusted publishing policy for this repository and the `ci.yml` workflow before release publishing can succeed.

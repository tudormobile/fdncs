# Building Library Documentation
The *FinancialData* library documentation can be built along with the source code using the *build.cmd* script found in the *src/* folder or directly on the command line.
```
build.cmd

-or-

dotnet tool update -g docfx
docfx docfx.json
```
Documentation is generated from xml code comments and combined with the files located in the */docs* folder to produce html based documentation. Output is collected in the *_site/* folder. Open "*index.html*" to view the generated documentation.

## Tooling & Directories
Tool dependencies are installed/updated as follows:
- docfx - documentation generation tool
- docs\docfx.json
    - Documentation

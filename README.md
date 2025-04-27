# Animal facts Client

[![Open in Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode-remote-try-dotnet)

.NET client for public Animal APIs. Currently the following API's are consumed:
- Cat Facts API, found at [catfact.ninja](https://catfact.ninja/).
    - Supports the following endpoints:
        - `/fact`
        - `/facts`
        - `/breeds`
- Dog Facts API, found at [dogapi.dog](https://dogapi.dog/).
    - Supports the following endpoints:
        - `/facts`
        - `/breeds`

Build with: `dotnet build`

Run with: `dotnet run`

The included Dev Container makes it easy to run the project in Docker via Visual Studio Code or use the included `Dockerfile`.

## TODOs
- Documentation
- Tests

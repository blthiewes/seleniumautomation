# SeleniumAutomation
This project runs selenium automation with dotnet core 2.2 and vscode

## Prerequisites
* [Git](https://git-scm.com/downloads) Installed
* [VS Code](https://code.visualstudio.com/Download) Installed
  * [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer) Extension
* [dotNet Core 2.2](https://dotnet.microsoft.com/download) Installed
* [Docker Desktop](https://www.docker.com/products/docker-desktop) Installed

## To Run
### Start Test Link
* `git clone https://github.com/bitnami/bitnami-docker-testlink.git`
* `docker-compose up` from bitnami-docker-testlink folder
* **Initialize Project so you go to Home Page after logging in**
### Start Selenium Tests
* open new terminal
* `git clone https://github.com/blthiewes/seleniumautomation.git`
* `code ./seleniumautomation`
* Run All Tests from .NET Test Expolorer on VS Code

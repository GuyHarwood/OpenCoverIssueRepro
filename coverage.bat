.\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user "-filter:+[SomeCompany.DemoLibrary]* -[*Tests]*" "-target:.\packages\NUnit.ConsoleRunner.3.5.0\tools\nunit3-console.exe" "-targetargs:.\SomeCompany.DemoLibrary.Tests\bin\Debug\SomeCompany.DemoLibrary.Tests.dll"

.\packages\ReportGenerator.2.4.5.0\tools\ReportGenerator.exe "-reports:results.xml" "-targetdir:.\coverage"

pause
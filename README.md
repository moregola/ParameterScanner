
# Revit Plugin



# Download .NET Framework Installer

For .NET Framework 4.7.2, visit the .NET Framework 4.7.2 download page[https://dotnet.microsoft.com/pt-br/download/dotnet-framework/net472].
For earlier versions, select the version you need from the .NET Framework downloads page.

Instructions for debug:

1. Download the .NET Framework installer.
2. Ensure that you have Revit 2020 installed.
3. Point the installer to the RevitAPI.dll file in the Revit 2020 installation folder.
4. Setup the project in Visual Studio to run external application to Debug [https://help.autodesk.com/cloudhelp/2020/ENU/Revit-API/images/VS2.png]
5. Configure addin.manifest with your Autodesk Revit Information.

Instructions for Real Test:

1. Download the .NET Framework installer.
2. Ensure that you have Revit 2020 installed (Let it closed until finish this instructions).
3. Point the installer to the RevitAPI.dll file in the Revit 2020 installation folder.
4. Setup the project in Visual Studio to run external application to Debug [https://help.autodesk.com/cloudhelp/2020/ENU/Revit-API/images/VS2.png]
5. Configure addin.manifest with your Autodesk Revit Information.
6. Change the Assembly tag to your dll in release build folder or downloaded package from GitHub
7. Copy the .addin file to the Revit Addins folder Autodesk\Revit\Addins{{RelYear}}\



References used to develop this task:

Test:
https://docs.google.com/document/d/1xJ6QQMkUeQwp40FLpegOJLnWR7KO9Jbw7SQw1Bss3ao/edit

Lib: 
https://github.com/dosymep/Autodesk.Revit.Sdk.Refs

Ribbon Tab
https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.tools.ribbon.ribbontab?view=vsto-2022

Autodesk Doc
https://www.autodesk.com/support/technical/article/caas/tsarticles/ts/7I2bC1zUr4VjJ3U31uM66K.html

Autodesk Plugin Lesson
https://www.autodesk.com/support/technical/article/caas/tsarticles/ts/20XnHfxUak5RFoowHpCOLh.html

Autodesk Doc: Filtering
https://help.autodesk.com/view/RVT/2020/ENU/?guid=Revit_API_Revit_API_Developers_Guide_Basic_Interaction_with_Revit_Elements_Filtering_Applying_Filters_html

Autodesk Geometry Lesson
https://www.autodesk.com/support/technical/article/caas/tsarticles/ts/1cm226GJNH8a6DUmV8G6dl.html

Revit Api Doc
https://www.revitapidocs.com/2020/

Filtering By Class
https://help.autodesk.com/view/RVT/2020/ENU/?guid=Revit_API_Revit_API_Developers_Guide_Basic_Interaction_with_Revit_Elements_Filtering_Applying_Filters_html
Imports System.ComponentModel.Design
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports Newtonsoft.Json
Module Module1
    Private myplayer As New players
    Private myProject As New Project


    Sub SaveProject()
        Dim Location As String = "C:\Users\Public\Documents"
        Dim filewriter As System.IO.StreamWriter
        filewriter = My.Computer.FileSystem.OpenTextFileWriter(Location + "\JsonbData.json", True)
        filewriter.Close()
    End Sub
End Module

'TODO:1. Change Procedure name to your own procedure name

'TODO:2.  Add Json package to the resources


'TODO:3. Create A Project Class

'TODO:4.  Create A Json file for the Project Class

'TODO:5.  Refactor writeFile procedure to take a string for data input

'TODO:6.  move the input variable up to the global class variable access

'TODO:7.  Seralize Project Class

'TODO:8.  Deseralize The Project json Class

'TODO:9.  Use snippets (insert comment) to add comments to procedures and functions

'TODO:10.Refactor your code to create subfolders in a separate procedure

'TODO:11.Remove reference comments



'Private filePath As String = "project.json"



Dim ProjectName As String

    Dim FullDirectory As String

    Sub Main()

        Dim input As String = 0

        While input <> "exit"

            Console.WriteLine("please enter product name.")

            ProjectName = Console.ReadLine

            Console.WriteLine("Please enter a command  Exit | create")

            input = Console.ReadLine.ToString()

            If input = "create" Then

                MakeP2PProjectFolders()

            End If

        End While

    End Sub

     Sub MakeProjectFolders()

        'TODO: Add Json database to store project information

        'TODO: Change MakeP2PProjectFolders to MakeProjectFolders

        Dim newFolderPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        If ProjectName = "" Then

            ProjectName = " Not Set\"

        End If

        Sub MakeProjectFolders()
        Dim newFolderPath As String = "C :\Users\Public\Documents"
          My.Computer.FileSystem.CreateDirectory(newFolderPath + ProjectName)

        CreateProjectFolder(newFolderPath, ProjectName)

        newFolderPath += "\" + ProjectName

        FullDirectory = newFolderPath
        'TODO:Adjust the folder to organize playlist data if needed
        CreateProjectFolder(newFolderPath, "\Docs")
        End Sub
        CreateProjectFolder($"{newFolderPath}\Docs", "Refs")
        CreateProjectFolder($"{newFolderPath}\Docs", "Word")
        CreateProjectFolder($"{newFolderPath}\Docs", "PDF")


        CreateProjectFolder(newFolderPath, "\Assets")
        CreateProjectFolder($"{newFolderPath}\Assets", "Art")
        CreateProjectFolder($"{newFolderPath}\Assets", "Images")

        WriteFile("ReadMe.txt", newFolderPath)
        WriteFile("ReadMe.txt", $"{newFolderPath}\Docs")


        Console.WriteLine("Project created in: " + FullDirectory)

    End Sub
Private Sub WriteFile(fileName As String, location As String)

    'Ref:https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-write-text-to-files-with-a-streamwriter
Sub WriteProjectFile()
    If fileName <> "" Then
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(location + "\" + fileName + ".json", True)
        file.WriteLine("Week 6 Folder Maker App)
        file.Close()
     
    



    End If
        End Sub

        Sub CreateProjectFolder(NewFolderPath As String, FolderName As String)
            
My.Computer .FileSystem.CreateDirectory(NewFolderPath + " \" + FolderName)"
        End Sub



End Module
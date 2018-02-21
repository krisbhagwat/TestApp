pipeline {
    agent any
    options {
              skipStagesAfterUnstable()
             }
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
                bat 'dotnet build MyTestApp.sln'
		bat "\"${tool 'MSBuild'}\" MyTestApp.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
                echo 'Build complete..'
            }
        }
        stage('Unit Test') {
            steps {
                echo 'Unit Testing..'
                sh "C:\\Windows\\System32\\cmd.exe /c C:\\Office\\Materials\\Jenkins\\NUnit.Console-3.8.0\\nunit3-console.exe C:\\Users\\bhagwatk\\.jenkins\\workspace\\DemoBuild\\TestProj\\bin\\Release\\TestProj.dll".execute()
                echo 'Unit Testing comeplete..'
            }
        }
        stage('Integration Test') {
            steps {
                echo 'Accpetance Testing..'
            }
        }
        stage('Accpetance Test') {
            steps {
                echo 'Accpetance Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}

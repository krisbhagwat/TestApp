pipeline {
    agent any
    options {
              skipStagesAfterUnstable()
             }
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
                "C:\\Windows\\System32\\cmd.exe C:\\Windows\\System32\\cmd.exe C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\MSBuild.exe MyTestApp.sln /p:Configuration=Release".execute()
                echo 'Build complete..'
            }
        }
        stage('Unit Test') {
            steps {
                echo 'Unit Testing..'
                "C:\\Windows\\System32\\cmd.exe C:\\Office\\Materials\\Jenkins\\NUnit.Console-3.8.0\\nunit3-console.exe C:\\Users\\bhagwatk\\.jenkins\\workspace\\DemoBuild\\TestProj\\bin\\Release\\TestProj.dll".execute()
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

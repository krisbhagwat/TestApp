pipeline {
    agent any
    options {
              skipStagesAfterUnstable()
             }
    stages {
        stage('Build') {
            steps {
                echo 'Building..'
                bat 'C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\MSBuild.exe MyTestApp.sln /p:Configuration=Release /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}'
		echo 'Build complete..'
            }
        }
    	stage('Execute Tests')
	    {
			parallel {
					stage('Unit Test') {
						steps {
							echo 'Unit Testing..'
							bat 'C:\\Office\\Materials\\Jenkins\\NUnit.Console-3.8.0\\nunit3-console.exe C:\\Users\\bhagwatk\\.jenkins\\workspace\\PipeLineBuild\\TestProj\\bin\\Release\\TestProj.dll'
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
				}
	    }
	
        stage('Arhive Build') {
            steps {
                echo "archiving build ${env.BUILD_NUMBER}"
		    bat "mkdir C:\\Office\\Jenkins\\Builds\\Build_${env.BUILD_NUMBER}"
		    bat "xcopy C:\\Users\\bhagwatk\\.jenkins\\workspace\\DemoBuild\\MyTestApp C:\\Office\\Jenkins\\Builds\\Build_${env.BUILD_NUMBER} /s /e /y"
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
		 bat 'xcopy C:\\Users\\bhagwatk\\.jenkins\\workspace\\DemoBuild\\MyTestApp C:\\Apps\\TestApp /s /e /y'
            }
        }
    }
}

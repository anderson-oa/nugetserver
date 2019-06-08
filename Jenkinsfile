pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                sh 'dotnet clean'
                sh 'dotnet restore'
                sh 'dotnet build'
            }
        }
        stage('Docker compose') {
            steps {
                sh 'cd NugetServer/ ls'
            }
        }
    }
}
pipeline {
    agent any
    stages {        
        stage('Docker compose') {
            steps {
                sh 'cd NugetServer; docker-compose up -d'
            }
        }
    }
}
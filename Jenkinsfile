pipeline {
    agent any
    stages {        
        stage('Docker compose') {
            steps {
                sh 'whoami; cd NugetServer; docker-compose up -d'
            }
        }
    }
}
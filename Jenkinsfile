pipeline {
    agent any
    stages {        
        stage('Docker compose') {
            steps {
                sh 'whoiam; cd NugetServer; docker-compose up -d'
            }
        }
    }
}
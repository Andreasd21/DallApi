pipeline {
  agent any
  stages {
    stage('Setup') {
      steps {
        git 'https://github.com/Andreasd21/DallFrontEnd.git'
        git 'https://github.com/Andreasd21/DallWarehouse.git'
      }
    }

    stage('Check setup') {
      steps {
        sh '''echo ls
ls
'''
      }
    }

  }
}
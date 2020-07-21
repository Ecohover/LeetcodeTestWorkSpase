def commitId
pipeline {
    agent none
    triggers {
        pollSCM 'H/5 * * * *'
    }
    stages {
        stage('Dotnet Build') {
            agent {
                label 'BuildServer'
            }
            steps {
                script {
                    commitId = bat(returnStdout: true, script: '@git rev-parse HEAD')//Get commit hash
                }
                bat """
                cd src
				dotnet restore
                dotnet build
                """
            }
            post {
                failure {
                    script {
                        NotifyMessage(commitId)
                    }
                }
            }
        }
    }
}


def NotifyMessage(String commitId ='', String extraMsg=''){

    buildStatus = currentBuild.currentResult //Get current build status
	if(commitId == ''){
		commitId = bat(returnStdout: true, script: '@git rev-parse HEAD')//Get commit hash
	}
	// Default values
	def colorCode = '#FF0000'
	def msg = "${env.JOB_NAME}[${env.BUILD_NUMBER}][${env.STAGE_NAME}] - ${currentBuild.currentResult} - \
		\nURL: ${env.BUILD_URL} with this repo: ${env.REPO}${commitId}"

	// Append extra msg
	if (extraMsg?.trim()) {
		msg = "${msg} \n${extraMsg}"
	}

	//
	if (buildStatus == 'SUCCESS') {
		colorCode = '#7FFF00'
	}
	else if(buildStatus == 'ABORTED') {
		colorCode = '#FFAA05'
	}
	else {
		colorCode = '#FF0000'
	}

	echo "Post result: ${currentBuild.result}"
	echo "Post currentResult: ${currentBuild.currentResult}"

	// Send notifications
	if(env.ENABLE_NOTIFY){
		office365ConnectorSend(color: colorCode, message: msg, webhookUrl:"https://outlook.office.com/webhook/d79cff7f-87db-4192-a7ce-984cb99fde42@9c5df620-ac96-4343-883d-e2fac493dcc0/IncomingWebhook/0e8bec3de7114679b59d22b520390dad/6d47c9d0-603e-46eb-8a05-54f032d84073")
	}
}
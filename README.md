Test NLog.Targets interaction with ElasticSearch

 General Requirements.

- This is .net 4.6.2 console application (you'll need install 4.6.2 version of .net framewrok on your PC) 
- For running ElasticSearch & Kibana you will need have installed docker

 Deploy on Windows

- open folder with solution and go to docker folder
- open cmd and make docker folder current
- type command: `docker-compose up` (when you don't need elastic anymore then press `ctrl + break` and type command `docker-compose down`)
- open solution in visual studio 2017 (2015) and run it
- open kibana by address `http://localhost:5601`
- if you will see message `"You only have a single index. You can create an index pattern to match it."` then create appropriate index pattern `testapp-log-*` in kibana
- go to discover section in kibana and check that logs are shown in kibana

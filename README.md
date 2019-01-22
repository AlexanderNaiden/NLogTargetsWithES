Test NLog.Targets interaction with ElasticSearch

 General Requirements.

- This is .net 4.6.2 console application (you'll need install 4.6.2 version of .net framewrok on your PC) 
- For running ElasticSearch & Kibana you will need have installed docker

 Deploy on Windows

- open folder with solution and go to docker folder
- open cmd and make docker folder current
- type command: docker-compose up (when you don't need elastic anymore then press ctrl + pause(break) and type command docker-compose down)
- open solution in visual studio 2017 (2015)
- go to `http://localhost:5601(kibana)` into discover section and check that log is shown in kibana

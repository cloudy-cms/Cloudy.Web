az acr login --name bjorngoranssoninvest
docker build -t bjorngoranssoninvest.azurecr.io/cloudyweb:latest .
docker push bjorngoranssoninvest.azurecr.io/cloudyweb:latest
```bash
docker run -d \
  -e POSTGRES_PASSWORD=PFG2cpm~sJ.WC0rGyqFKf0 \
  -e POSTGRES_HOST_AUTH_METHOD=scram-sha-256 \
  -e POSTGRES_HOST_AUTH_METHOD=trust \
  -e POSTGRES_DB=fusiondb \
  -p 5432:5432 \
  -v TestFhirServerPostgres.AppHost-postgres-data:/var/lib/postgresql/data docker.io/library/postgres:16.4	
```  
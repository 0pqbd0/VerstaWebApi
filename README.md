# Веб-приложение на ASP .NET Core и React

## Установка и настройка
### Установка

1. Клонируйте репозиторий:
    
    ```bash
    git clone https://github.com/0pqbd0/VerstaWebApi.git
    cd VerstaWebApi
    ```

2.  Поднять базу данных с помощью docker-compose:
   
    ```bash
    cd backend/
    cd VerstaWeb
    docker-compose up -d  
    ```
3.  Примените миграции:

    ```bash
    dotnet ef database update
    ```  

4. Запустите сервер приложения:

    ```bash
    cd VerstaWeb
    dotnet run --launch-profile "https"
    ```

5. Запустить фронтенд приложения:
    ```bash
    cd -
    npm install
    npm install antd
    cd frontend/
    npm start
    ```

После запуска приложения, оно будет доступно по адресам:  
Swagger документация Backend: `[https://localhost:7235/swagger/index.html`.  
Frontend: `http://localhost:3000`


Этот проект лицензируется по лицензии MIT. Подробности см. в файле `LICENSE`.

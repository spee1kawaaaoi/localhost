# localhost API

##  О проекте
Данный проект представляет собой RESTful API, разработанный на платформе **ASP.NET Core**. 
API предназначено для управления данными пользователей (Users) и категорий (Categories). Проект использует базу данных **PostgreSQL** для хранения информации.

##  Стек технологий
* **Язык программирования:** C# (.NET 9+, судя по формату решения `.slnx`)
* **Фреймворк:** ASP.NET Core Web API
* **База данных:** PostgreSQL
* **Провайдер БД:** Npgsql
* **Формат решения:** `.slnx`

##  Структура проекта
* `Controllers/` — API контроллеры для обработки HTTP-запросов (например, `UsersController`, `CategoriesController`).
* `Services/` — бизнес-логика приложения (например, `TransactionService`).
* `Models/` — классы-модели данных (`User`, `Category`), описывающие структуру таблиц в БД.
* `database.sql` — SQL-скрипт для инициализации и создания структуры базы данных.
* `localhost.slnx` — файл решения Visual Studio.

##  Реализованный функционал (Эндпоинты)
На данный момент реализованы следующие эндпоинты (базовый маршрут: `api/[controller]`):

**Пользователи (Users):**
* `GET /api/users` — получение списка всех пользователей из базы данных. (Реализовано напрямую через `NpgsqlConnection`, возвращает `id`, `username`, `email`, `created_at`).

**Категории (Categories):**
* `GET /api/categories` — получение списка всех категорий. (Реализовано через внедрение зависимостей (DI) сервиса `TransactionService`, метод `GetCategoriesAsync`).

## Установка и запуск

### Предварительные требования
* Установленный [.NET SDK](https://dotnet.microsoft.com/download) (версия 8.0 или 9.0)
* Установленный сервер [PostgreSQL](https://www.postgresql.org/download/)

### Шаги для запуска
1. **Клонируйте репозиторий:**
   ```bash
   git clone https://github.com/spee1kawaaaoi/localhost.git
   cd localhost

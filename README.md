# CommandsTest

Simple WEB API project made in ASP.NET Core 3.1. 


# Requests Schema

## GET
```
https://localhost:44346/commands/ **Requires Authentication**
https://localhost:44346/commands/{id}/ **Requires Authentication**
```

## POST

**Get JWT Token**

```
https://localhost:44346/users/authenticate/

Example Request Body (JSON):

{
    "username": "demo",
    "password": "demo"
}
```

**Add a new command**
```
https://localhost:44346/commands/ **Requires Authentication**

Example Request Body (JSON):

{
    "description": "Description 35",
    "key": "Key 35"
}
```

## DELETE

```
https://localhost:44346/commands/{id} **Requires Authentication**
```

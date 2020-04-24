# CatBoardApi
### By **Keturah Howard, Jamison Cozart, Dusty McCord**  March 30th 2020

ASP.NET core console application to demonsteate how to make an API, using the example of a reddit only based around cats: CatBoard.

***[Application that holds both the API and Interface for the API](https://github.com/KeturahDev/CatBoard)***

## Specifications user stories:

* As a user, I want to be able to GET all Boards so that I can choose which content to consume.
* As a user, I want to be able to GET all Posts relating to a Board so that I can enjoy the relevent content.
* As a user, I want to be able to POST Boards to create a place to post relative Posts.
* As a user, I want to be able to POST posts for myself and others to enjoy.
* As a user, I want to be able to CREATE Boards, so that others and myself can contribute new collections of posts. 
* As a user, I want to be able to CREATE Posts.
* As a user, I want to be able to DELETE Boards to declutter.
* As a user, I want to be able to DELETE Posts to declutter.

### API Endpoints

BOARDS
```
GET /api/boards
POST /api/boards
GET /api/boards/{boardId}
PUT /api/boards/{boardId}
DELETE /api/boards/{boardId}
```

POSTS
```
GET /api/boards/{boardId}/Posts
POST /api/boards/{boardId}/Posts
GET /api​/boards​/{boardId}​/Posts​/{id}
PUT /api​/boards​/{boardId}​/Posts​/{id}
DELETE /api/boards/{boardId}/Posts/{id}
PATCH /api​/boards​/{boardId}​/Posts​/{id}​/upvote
PATCH /api/boards/{boardId}/Posts/{id}/downvote
```

COMMENTS (*- Interface: work in progress -*)
```
GET /api/boards/{boardId}/posts/{postId}/Comments
POST /api/boards/{boardId}/posts/{postId}/Comments
GET /api/boards/{boardId}/posts/{postId}/Comments/{id}
PUT /api/boards/{boardId}/posts/{postId}/Comments/{id}
DELETE /api/boards/{boardId}/posts/{postId}/Comments/{id}
```

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/KeturahDev/CatBoardApi.git
    ```

2. Restore all dependencies:
    ```
    dotnet restore
    ```

### Open program

3. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```

## Technologies Used

* C#
* ASP.NET core MVC 2.2
* RestSharp API
* Newtonsoft.Json
* Git

## External Assets
* MySqlWorkBench
* Postman


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email us at 
* keturah.dev@gmail.com.
* jamisoncozart@gmail.com


## License

Licensed under the MIT license.

&copy; 2020 Keturah Howard, Jamison Cozart, Dusty McCord.

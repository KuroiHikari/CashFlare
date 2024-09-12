# CashFlare website using React and ASP.NET API

This project is a web-based financial application built with **React (TypeScript, HTML, CSS)** for the frontend and **ASP.NET API** for the backend. The application provides financial help by allowing users to search for companies, store them in a portfolio, and view detailed financial information such as company profiles, income statements, balance sheets, and cash flow statements.

<img src="https://github.com/user-attachments/assets/a621a80f-972e-42a5-b55c-a5f217fe9dfc" width="330" height=auto alt="Image 1">
<img src="https://github.com/user-attachments/assets/03f1e3c5-60db-48b5-a1f5-86f9960cf133" width="330" height=auto alt="Image 2">
<img src="https://github.com/user-attachments/assets/059e5428-3814-4316-a930-569d22da4d91" width="330" height=auto alt="Image 3">
<img src="https://github.com/user-attachments/assets/f4b7b298-b213-4fe1-a324-109d871d67a0" width="330" height=auto alt="Image 4">

## Features

* **Search Companies**: Search for companies using keywords and filter by tags.
* **Portfolio Management**: Add selected companies to a portfolio for quick access.
* **Company Details**: View detailed information about each company including:
  - Company Profile
  - Financial Data
  - Income Statement
  - Balance Sheet
  - Cash Flow Statement
* **Authentication**: User registration and login.
* **Portfolio Storage**: Save companies in your personal portfolio via API.

## Technologies Used

### Frontend:
- **React** (TypeScript, HTML, CSS)
  
### Backend:
- **ASP.NET Core API** (C#)

### External Services:
- Financial data is retrieved from [Financial Modeling Prep API](https://site.financialmodelingprep.com/)
- User authentication and portfolio management are handled by the custom-built ASP.NET API

## Getting Started

### Prerequisites

Ensure that you have the following installed on your machine:
- **Node.js**: Required to run the React frontend
- **.NET 8 SDK**: Required to run the ASP.NET Core backend
- **Git**: To clone the repository
- **MS SQL Server 2022**: Required to run the database for API

### Installation

#### 1. Clone the repository:
```bash
git clone https://github.com/KuroiHikari/CashFlare.git
```

### 2. Set up the FrontEnd:
- Make sure you're in CashFlare/frontend folder
```bash
npm install
```

### 3. Set up the database:
- You can either download database backup file and restore it or create fresh one
#### a) Restoring database
- Download the backup file CashFlare/db/CashFlare.bk
- Restore DB
- CashFlare/api/appsettings.json - in **DefaultConnection** change data source (YOUR_PC_NAME) and catalog (YOUR_DATABASE_NAME)
#### b) Creating database
- Create new DB
- CashFlare/api/appsettings.json - in **DefaultConnection** change data source (YOUR_PC_NAME) and catalog (YOUR_DATABASE_NAME)
- Make sure you're in CashFlare/api folder
```bash
  dotnet ef database update
```

### 4. Set up the backend:
- Make sure you're in CashFlare/api folder
```bash
dotnet restore
```

### 5. API Key:
- You will need to create an account from [Financial Modeling Prep API](https://site.financialmodelingprep.com/) to fetch financial data
- After registering, go to dashboard and copy the API key
- Add this API key to your project in CashFlare/frontend/.env and CashFlare/api/appsettings.json (replace YOUR_API_KEY with API key from the website)

### Running the Application

#### Starting the API:
- Make sure you're in CashFlare/api folder
```bash
  dotnet watch run
```

#### Starting the Frontend:
- Make sure you're in CashFlare/frontend folder
```bash
  npm start
```
- After that you're good to go!

#### URLs
- API => http://localhost:3000/
- Frontend => http://localhost:5014/







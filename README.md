# SE_Project_Sem5  

Yo, welcome to the setup guide for this WPF app that vibes with SQLExpress. Just follow these steps, and you'll be golden.  

## What You Need  
- [SQL Server Management Studio (SSMS)](https://aka.ms/ssmsfullsetup) – aka your database BFF  
- Visual Studio (with .NET Desktop Dev tools and Entity Framework Core swag installed via NuGet)  

## How to Get This Bad Boy Running  

### Step 1: Grab SQL Server  
1. Download SSMS from [here](https://aka.ms/ssmsfullsetup).  
2. Install it like a boss.  

### Step 2: Make Sure SQLExpress is Alive  
1. Open **SQL Server Configuration Manager** (sounds fancy, but you got this).  
2. Go to **SQL Server Services** and check if `SQL Server (SQLExpress)` is up and running.  
   - Not running? Right-click that bad boy and hit **Start**.  

### Step 3: Link SQLExpress to Visual Studio  
1. Open **Visual Studio** (you’re already here, so props).  
2. Pull up the **SQL Server Object Explorer** window (View -> SQL Server Object Explorer).  
3. Click the **Add SQL Server** icon (the one next to the refresh button).  
4. Connect to your local server: `localhost\SQLEXPRESS`.  

### Step 4: Build the Database  
1. In **SQL Server Object Explorer**, find your server.  
2. Right-click **Databases** -> **Add New Database**.  
3. Name it: `TravelPlannerDB` (don’t freestyle the name; it’s important).  

### Step 5: Let the Migrations Do Their Thing  
1. In Visual Studio, go to **Tools** -> **NuGet Package Manager** -> **Package Manager Console**.  
2. Hit this command in the console:  
   ```bash  
   Update-Database  

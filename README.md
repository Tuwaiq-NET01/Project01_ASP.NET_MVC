# Domain Info

<p align="center">
<img src="https://raw.githubusercontent.com/AWManeea/Project01_ASP.NET_MVC/main/wwwroot/assets/logo.png" height="128px"></p>
Domain Info is a web application built with ASP.NET MVC Framework to facilitate
gathering information about a given domain. It allows users to ask for a
plethora of different DNS record types and public WHOIS Records.

## Demo

A [live demo](https://domaininfo.azurewebsites.net/) has been deployed to Azure
for those who prefer not to clone the project and deploy it.

## Project Structure

The project has been structured in the following way:

```bash
Models/
├── Domain.cs
├── DNSRecord.cs
├── DNSRecords.cs
└── WhoisRecord.cs
Controllers/
├── HomeController.cs
├── DNSController.cs
└── WhoisController.cs
Views/
├── DNS
│   ├── Index.cshtml
│   └── Lookup.cshtml
├── Home
│   └── Index.cshtml
└── Whois
    ├── Index.cshtml
    └── Lookup.cshtml
```

## APIs Under the Hood

Since it provides two distinct services, the web app uses two different APIs to
retrieve the data. The first of which is
[Google's public DNS JSON API](https://developers.google.com/speed/public-dns/docs/doh/json)
and the second is a custom API end-point that I have created to retrieve WHOIS
records. The WHOIS endpoint is located at
[Maneea.net/api/whois/{domain}](http://maneea.net/api/whois/example.com) and can
be used for free, for ever :)

## Usage

To download and use the web app locally, simply copy and paste the following
snippet into the terminal:

```bash
# Downloads the repository (clone it) locally.
git clone https://github.com/AWManeea/Project01_ASP.NET_MVC.git

# Change the current working directory and go into the project
cd Project01_ASP.NET_MVC

# Simply run it from the command line with the following command
dotnet run
```

# Monolith - EmailService

This project showcases a mail-sending service, implemented using all major
monolithic architectures used in backend development.

## Tech stack

- .NET (ASP.NET Core Web API)

## Packages Installed

- **Swashbuckle** — for API documentation (Swagger UI)
- **MailKit** — for sending emails via SMTP

## Running locally

\`\`\`bash
dotnet restore
dotnet run
\`\`\`

Then visit `https://localhost:{port}/swagger` to try the API.

## Example request

\`\`\`http
POST /api/email/welcome
Content-Type: application/json

{
  "name": "Priya",
  "email": "priya@example.com"
}
\`\`\`

---
_Last updated: 21 September 2026, 20:31 PM_
# mail-project
The project is to showcase mail sending service via all technical architectures used in backend development.

| Architecture | Status | Folder |
|---|---|---|
| Layered (Monolith) | ⬜ Not Started | [01-layered](./Monolith) |
| Clean Architecture | ⬜ Not Started | [02-clean-architecture](./02-clean-architecture) |

## I. Monolith Architecture

**PROS:**
- Everything lives in one codebase and one deployable unit, so setup, debugging, and running the whole app locally is simple — no juggling multiple services or repos.
- Fewer moving parts means fewer failure points: no network calls between internal components, no distributed tracing needed to find a bug.
- Fastest to build and ship early — ideal for small teams, MVPs, or learning projects where speed matters more than long-term scale.

**CONS:**
- As features grow, the codebase can turn into a tangled "big ball of mud" if layers/modules aren't disciplined — one team's change can unexpectedly break another's code.
- Scaling means scaling the *entire* app, even if only one small part (e.g. email sending) is under heavy load — you can't scale pieces independently.
- Every deployment ships the whole application at once, so a small bug fix requires redeploying everything, and one failing module can take the whole app down.

_Last updated: 21 September 2026 : 20:31 P.M._


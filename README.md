# Pidgeon E2E Orders Service

This repository represents the orders service used by the SDG.Pidgeon topology compiler CI.

## How it participates
- Builds and tests a minimal .NET solution.
- Publishes `service-declaration.yaml` as a CI artifact for topology compilation.

## Service declaration
The `service-declaration.yaml` file describes the message routes owned by orders-service.
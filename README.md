# Pidgeon E2E Orders Service

Minimal RPC responder used by the SDG.Pidgeon topology compiler pipeline.

## Messages
- Handles `query.orders.getbyid` (request) and responds with `query.orders.getbyid.response`.
- Publishes `event.orders.created.v1` (publish).

## Service declaration
Path: `service-declaration.yaml`

CI uploads this file as the `service-declaration` artifact. The central topology
pipeline collects these artifacts and runs:

```
pwsh eng/scripts/compile-topology.ps1 `
  -BaseTopologyPath docs/topology/samples/topology.base.yaml `
  -DeclarationsDir artifacts/service-declarations `
  -OutputDir out
```

## Topology consumption
Deployments pin a versioned topology artifact and extract:

```
exports/<environment>/orders-service/topology.yaml
```

The sample app reads the topology path from `PIDGEON_TOPOLOGY_PATH`.

## SDG.Pidgeon dependency
This repo consumes SDG.Pidgeon via the `vendor/SDG.Pidgeon` git submodule.

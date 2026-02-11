# 🚀 EnterpriseApp – Cloud-Native Microservices Platform

![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![Angular](https://img.shields.io/badge/Angular-Latest-red)
![Docker](https://img.shields.io/badge/Docker-Enabled-blue)
![Kubernetes](https://img.shields.io/badge/Kubernetes-Production--Ready-326CE5)
![Architecture](https://img.shields.io/badge/Architecture-Clean-green)
![Microservices](https://img.shields.io/badge/Microservices-Event--Driven-orange)
![License](https://img.shields.io/badge/License-MIT-lightgrey)

Enterprise-grade SaaS platform built using **Clean Architecture**, **Microservices**, and **Cloud-Native DevOps practices**.

Designed for **Senior / Lead / Architect-level engineering standards**.

---

# 🏗️ System Architecture

![Architecture Overview](docs/architecture.png)

## 🔁 High-Level Flow

```
Angular SPA
     ↓
API Gateway (YARP)
     ↓
----------------------------
| Auth Service             |
| User Service             |
----------------------------
     ↓
RabbitMQ (Event Bus)
     ↓
Redis Cache
     ↓
SQL Server Cluster
```

---

# 📁 Project Structure

```
EnterpriseApp/

services/
│
├── Gateway/
│   └── Gateway.API
│
├── AuthService/
│   ├── Domain
│   ├── Application
│   ├── Infrastructure
│   ├── Persistence
│   └── API
│
├── UserService/
│   ├── Domain
│   ├── Application
│   ├── Infrastructure
│   ├── Persistence
│   └── API
│
frontend/
│   └── Angular + NgRx
│
docker-compose.yml
k8s/
.github/workflows/
docs/
```

---

# 🧠 Architecture Principles

- Clean Architecture (Onion Model)
- Dependency Inversion
- CQRS-ready structure
- Event-driven communication
- Stateless services
- Cloud-native scalability
- Domain-driven separation
- Microservice isolation

---

# 🔐 Authentication & Security

- JWT Access Tokens (15 min expiry)
- Refresh Tokens (7 days)
- Role-Based Authorization
- Policy-Based Authorization
- Swagger secured with JWT
- API Rate Limiting
- Multi-Tenant Ready
- HTTPS enforced in production
- Secure environment variables

---

# 📨 Event-Driven Architecture

![Event Flow](docs/event-driven.png)

### Example Flow

1. User registers  
2. Auth Service publishes `user.created` event  
3. RabbitMQ queues event  
4. User Service consumes event  
5. User profile created asynchronously  

### Benefits

- Loose coupling
- Independent deployments
- High scalability
- Fault tolerance
- Horizontal scaling ready

---

# ⚡ Redis Distributed Caching

Redis is used for:

- Token blacklisting
- Session caching
- Dashboard data caching
- Rate limiting
- Distributed performance optimization

---

# 🐳 Run With Docker (Recommended)

## 1️⃣ Build & Start Containers

```bash
docker compose up -d --build
```

## 2️⃣ Access Services

| Service | URL |
|----------|------|
| API Gateway | http://localhost:5000 |
| RabbitMQ UI | http://localhost:15672 |
| SQL Server | localhost:1433 |
| Redis | localhost:6379 |

RabbitMQ default credentials:

```
guest / guest
```

---

# 🖥️ Run Without Docker

## Backend

```bash
dotnet build
dotnet run --project services/AuthService/AuthService.API
dotnet run --project services/UserService/UserService.API
dotnet run --project services/Gateway/Gateway.API
```

## Frontend

```bash
cd frontend/enterprise-frontend
npm install
ng serve
```

---

# ☸️ Kubernetes Production Deployment

## Create Namespace

```bash
kubectl create namespace enterprise-prod
```

## Deploy

```bash
kubectl apply -f k8s/
```

## Check Pods

```bash
kubectl get pods -n enterprise-prod
```

---

# 🔄 CI/CD Pipeline

Pipeline file:

```
.github/workflows/ci-cd.yml
```

### Pipeline Stages

- Restore dependencies
- Build
- Run tests
- Build Docker image
- Push to registry
- Deploy to Kubernetes (optional stage)

---

# 📊 Monitoring & Observability (Extendable)

Ready to integrate:

- Serilog logging
- Prometheus metrics
- Grafana dashboards
- Distributed tracing
- Health checks endpoint `/health`
- Centralized logging system

---

# 🏢 Enterprise Features

- Horizontal Pod Autoscaling (HPA)
- API Versioning
- Rate Limiting
- Health Checks
- Multi-Tenant Support
- Reverse Proxy via Ingress
- Event-driven communication
- Cloud-native scalability
- Independent service deployment
- Infrastructure ready for Helm/Terraform

---

# 🧪 Testing Strategy

- Unit Tests (Domain + Application)
- Integration Tests (API)
- Contract Testing (Events)
- End-to-End Testing (Angular)
- Performance testing ready

---

# 🚀 Production Deployment Strategy

1. Build Docker images
2. Push to container registry
3. Deploy via Kubernetes
4. Configure Ingress controller
5. Enable autoscaling
6. Integrate monitoring stack
7. Enable centralized logging

---

# 📌 Resume Summary Version

Designed and implemented a cloud-native microservices platform using .NET 8 and Angular. Applied Clean Architecture per service, implemented JWT authentication with refresh tokens, integrated Redis distributed caching, built event-driven communication using RabbitMQ, configured API Gateway routing with YARP, containerized applications using Docker, and deployed to Kubernetes with autoscaling and CI/CD automation.

---

# 🎯 Ideal For

- Senior Backend Developers
- Full-Stack Engineers
- Solution Architects
- DevOps Engineers
- Cloud Engineers

---

# 📜 License

MIT License

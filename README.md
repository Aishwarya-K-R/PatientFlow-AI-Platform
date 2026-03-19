# 🚀 PatientFlow Platform: Scalable Cloud-Native Microservices for Healthcare Ops

## 📌 Overview

**PatientFlow Platform** is a **cloud-native, microservices-based healthcare backend system** designed to manage patient operations efficiently and scalably.

The platform demonstrates **real-world production architecture patterns**, including:
- Microservices architecture
- Event-driven communication
- API Gateway pattern
- Observability & monitoring
- CI/CD automation
- Containerization & orchestration

It simulates how modern healthcare platforms **handle patient data, authentication, billing, and system communication at scale.**


## 🏗️ Architecture

![Architecture Diagram](https://github.com/user-attachments/assets/e834db75-f226-4d93-a0e7-fa43e3d3983c)


## 🔧 Core Components

### 1. API Gateway
- Central entry point for all client requests
- Handles routing, aggregation, rate limiting, and health checks

### 2. Microservices
- **Auth Service** → Authentication & authorization  
- **Patient Service** → Patient data management  
- **Billing Service** → Billing and transactions  

### 3. Communication Layer
- **gRPC** → Fast synchronous communication between services  
- **Kafka** → Event-driven asynchronous messaging  

### 4. Data Layer
- **PostgreSQL** → Persistent storage  
- **Redis** → Caching and fast data access  

### 5. Observability
- **Prometheus** → Metrics collection  
- **Grafana** → Visualization dashboards  

### 6. DevOps & Deployment
- **Docker** → Containerization  
- **GitHub Actions (CI/CD)** → Automated build & push  
- **Kubernetes (Manifests)** → Orchestration-ready setup  


## ⚙️ System Functionality

The platform simulates a real healthcare workflow:

1. User authentication using **JWT-based RBAC** via Auth Service  
2. Patient data creation and retrieval  
3. Billing operations triggered via events  
4. Service communication:
   - **Synchronous → gRPC**
   - **Asynchronous → Kafka**
5. API Gateway:
   - Routes all external requests
   - Applies rate limiting
6. Health checks ensure service availability  
7. Metrics are monitored in real-time via **Prometheus and Grafana**


## 🔄 CI/CD Pipeline

The project includes a fully automated pipeline:

### 1. Workflow
- Code pushed to repository  
- GitHub Actions triggers pipeline  
- Docker images built for each service  
- Images pushed to Docker Hub  

### 2. Outcome
- Ready-to-deploy container images  
- Consistent and automated builds  


## ☸️ Kubernetes Support

Kubernetes manifests are included for all services.

⚠️ **Note:**
- Deployment may fail on low-resource systems (e.g., Minikube) due to memory limits  
- Recommended to use a cloud Kubernetes cluster for full setup  


## 🛠️ Setup & Installation

### 1. Clone Repository
git clone https://github.com/Aishwarya-K-R/PatientFlow-Platform.git
**cd PatientFlow-Platform**   
2. Create **.env** file in the project root and provide the data required for **docker-compose.yml** file  
3. For Kubernetes setup, provide the required data in **secrets.yml and config-map.yml** files  
4. Run with Docker Compose: **docker-compose up --build**  
5. Run Kubernetes (based on the setup): **kubectl apply -f Kubernetes/**   
6. Access the services:  
- **API Gateway:** http://localhost:4004/   
- **Health Check:** http://localhost:4004/health  
- **Kafka UI:** http://localhost:8080  
- **Prometheus:** http://localhost:9090  
- **Grafana:** http://localhost:3000  

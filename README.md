# 🚀 PatientFlow Platform: Scalable Cloud-Native Microservices for Healthcare Ops

## 📌 Overview

**PatientFlow Platform** is a **cloud-native, microservices-based healthcare backend system** designed to manage patient operations **efficiently, securely, and scalably**.

The platform demonstrates **real-world production architecture patterns**, including:
- **Microservices architecture** with independent, scalable services
- **Event-driven communication** via Kafka for asynchronous workflows
- **API Gateway pattern** for centralized routing, aggregation, and rate-limiting
- **Observability & monitoring** with Prometheus and Grafana
- **CI/CD automation** for consistent, production-ready deployments
- **Containerization & Orchestration** with Docker and Kubernetes
- **Automated testing** for critical services like Auth and Patient management to ensure reliability
- **AI-powered LLM integration**, providing an intelligent chatbot that can answer patient-related queries using cached context from Redis and database records

It **simulates how modern healthcare platforms** handle authentication, patient data, billing, and system communication **at scale**, now enhanced with **robust testing and AI capabilities** to make the system more reliable and intelligent.

It simulates how modern healthcare platforms **handle patient data, authentication, billing, and system communication at scale.**


## 🏗️ Architecture

<img src="https://github.com/user-attachments/assets/e834db75-f226-4d93-a0e7-fa43e3d3983c" width="750" height="750" alt="Architecture Diagram" />


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


## 🛠️ Steps for Implementation

1. Clone Repository:   
**git clone** https://github.com/Aishwarya-K-R/PatientFlow-Platform.git   
**cd PatientFlow-Platform**   
2. Create **.env** file in the project root and provide the data required for **docker-compose.yml** file  
3. For Kubernetes setup, provide the required data in **secrets.yml and config-map.yml** files  
4. Run with Docker Compose: **docker-compose up --build**  
5. Access the services:  
- **API Gateway:** http://localhost:4004/   
- **Health Check:** http://localhost:4004/health  
- **Kafka UI:** http://localhost:8080  
- **Prometheus:** http://localhost:9090  
- **Grafana:** http://localhost:3000
6. Run Kubernetes and accesss the services using domain name (based on the setup): **kubectl apply -f Kubernetes/**
  

## 📊 Event Streaming via Apacke Kafka

### 🟢 Producer: Patient Service publishes patient events to Kafka   
<img width="700" height="700" alt="image" src="https://github.com/user-attachments/assets/5f01982f-3439-4f4c-8aff-90b833ea38fb" />   

### 🔵 Consumer: Billing Service listens to events and creates billing account asynchronously
<img width="700" height="700" alt="image" src="https://github.com/user-attachments/assets/ebf17fd4-2bae-47ba-b86e-172247b41d85" /> 


## 📊 Monitoring & Observability Stack

### 🟢 Prometheus: Collects and aggregates real-time metrics across microservices for deep system observability
<img width="700" height="700" alt="image" src="https://github.com/user-attachments/assets/b0662457-c002-446c-bf97-d21936efbd02" />
<img width="700" height="700" alt="image" src="https://github.com/user-attachments/assets/a2e166e9-78c7-49dd-98ee-8d52aa1e6bcb" />
  

### 🔵 Grafana: Transforms metrics into powerful visual dashboards for real-time insights and performance monitoring
<img width="800" height="800" alt="image" src="https://github.com/user-attachments/assets/2c53866d-f42f-4b51-8399-1974b614ce09" />

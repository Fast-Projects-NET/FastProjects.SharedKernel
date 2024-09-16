<div align="center">
  <img src="docs/assets/logo.png" alt="Project Logo" width="800"/>
</div>

# 🚀 **FastProjects.SharedKernel**

![Build Status](https://github.com/Fast-Projects-NET/FastProjects.SharedKernel/actions/workflows/test.yml/badge.svg)
![NuGet](https://img.shields.io/nuget/v/FastProjects.SharedKernel.svg)
![NuGet Downloads](https://img.shields.io/nuget/dt/FastProjects.SharedKernel.svg)
![License](https://img.shields.io/github/license/Fast-Projects-NET/FastProjects.SharedKernel.svg)
![Last Commit](https://img.shields.io/github/last-commit/Fast-Projects-NET/FastProjects.SharedKernel.svg)
![GitHub Stars](https://img.shields.io/github/stars/Fast-Projects-NET/FastProjects.SharedKernel.svg)
![GitHub Forks](https://img.shields.io/github/forks/Fast-Projects-NET/FastProjects.SharedKernel.svg)



> 🚨 ALERT: Project Under Development
> This project is not yet production-ready and is still under active development. Currently, it's being used primarily for personal development needs. However, contributions are more than welcome! If you'd like to collaborate, feel free to submit issues or pull requests. Your input can help shape the future of FastProjects!

---

## 📚 **Overview**

Package of some useful base classes that are used in Clean Architecture templates with DDD.

---

## 🛠 **Roadmap**

- Domain Layer classes:
    - ✅ [IAggregateRoot](src/FastProjects.SharedKernel/IAggregateRoot.cs) - Interface for Aggregate Root
    - ✅ [EntityBase](src/FastProjects.SharedKernel/EntityBase.cs) - Base class for entities
    - ✅ [DomainEventBase](src/FastProjects.SharedKernel/DomainEventBase.cs) - Base class for domain events
    - ✅ [HasDomainEventsBase](src/FastProjects.SharedKernel/HasDomainEventsBase.cs) - Base classes that have domain events
- Domain Event Dispatcher:
    - ✅ [IDomainEventDispatcher](src/FastProjects.SharedKernel/IDomainEventDispatcher.cs) - Interface for domain event dispatcher
    - ✅ [MediatRDomainEventDispatcher](src/FastProjects.SharedKernel/MediatRDomainEventDispatcher.cs) - Domain event dispatcher that uses MediatR
- Application Layer classes:
    - ✅ [ICommand](src/FastProjects.SharedKernel/ICommand.cs) - Interface for commands
    - ✅ [ICommandHandler](src/FastProjects.SharedKernel/ICommandHandler.cs) - Interface for command handlers
    - ✅ [IQuery](src/FastProjects.SharedKernel/IQuery.cs) - Interface for queries
    - ✅ [IQueryHandler](src/FastProjects.SharedKernel/IQueryHandler.cs) - Interface for query handlers
- Pipeline Behaviors for MediatR:
    - ✅ [LoggingBehavior](src/FastProjects.SharedKernel/Behaviors/LoggingBehavior.cs) - Pipeline behavior for logging
    - ✅ [ValidationBehavior](src/FastProjects.SharedKernel/Behaviors/ValidationBehavior.cs) - Pipeline behavior for validation
- Others
    - ✅ [PagedList](src/FastProjects.SharedKernel/PagedList.cs) - Class for paginated lists
    - ✅ [IUnitOfWork](src/FastProjects.SharedKernel/IUnitOfWork.cs) - Interface for Unit of Work pattern

---

## 🚀 **Installation**

You can download the NuGet package using the following command to install:
```bash
dotnet add package FastProjects.SharedKernel
```

---

## 🤝 **Contributing**

This project is still under development, but contributions are welcome! Whether you’re opening issues, submitting pull requests, or suggesting new features, we appreciate your involvement. For more details, please check the [contribution guide](CONTRIBUTING.md). Let’s build something amazing together! 🎉

---

## 📄 **License**

FastProjects is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for full details.

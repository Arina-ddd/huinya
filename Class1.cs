using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace USQLCSharpProject6
{
    /// <summary>
    /// Класс представляет собой заявку на ремонт.
    /// </summary>
    public class RequestRemont
    {
        /// <summary>
        /// Идентификатор заявки на ремонт.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Тип оборудования.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNumber { get; private set; }
        /// <summary>
        /// Описание проблемы.
        /// </summary>
        public string Description  { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Дата и время создания заявки.
        /// </summary>
        public DateTime CreateAt { get; private set; }
        /// <summary>
        /// Дата и время обновления заявки.
        /// </summary>
        public DateTime UpdateAt { get; private set;}
        /// <summary>
        /// Дата и время завершения заявки.
        /// </summary>
        public DateTime FinishAt { get; private set; }
        /// <summary>
        /// Статус заявки
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// Конструктор класса заявка на ремонт.
        /// </summary>
        /// <param name="id">Идентификатор заявки на ремонт.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        public RequestRemont(int id, int ClientId)
        {
            ID = id;
            Equipment = string.Empty;
            SerialNumber = string.Empty;
            Description = string.Empty;
            ClientId = ClientId;
            Priority = string.Empty;
            CreateAt = DateTime.MinValue;
            UpdateAt = DateTime.Now;
            FinishAt = DateTime.MaxValue;
            Status = string.Empty;
        }
    }
    /// <summary>
    /// Класс регистрации заявки.
    /// </summary>
    public class RequestRegistary
    {
        /// <summary>
        /// Идентификатор регистрации заявки.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Дата и время создания заявки.
        /// </summary>
        public DateTime CreateAt { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Тип оборудования.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNumber { get; private set; }
        /// <summary>
        /// Описание проблемы.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Конструктор класса регистрация заявки.
        /// </summary>
        /// <param name="id">Идентификатор регистрации заявки.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        public RequestRegistary(int id, int ClientId)
        {
            ID = id;
            CreateAt= DateTime.Now;
            Priority = string.Empty;
            ClientId = ClientId;
            Equipment = string.Empty;
            SerialNumber = string.Empty;
            Description = string.Empty;
        }
    }
    /// <summary>
    /// Класс обработки заявки.
    /// </summary>
    public class RequestProcessor
    {
        /// <summary>
        /// Идентификатор оботки заявки.
        /// </summary>
        public int ID { get; private set;}
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; }
        /// <summary>
        /// Идентификатор исполнителя.
        /// </summary>
        public int ExecutorId { get; private set;}
        /// <summary>
        /// Тип оборудования.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNumber { get; private set; }
        /// <summary>
        /// Описание проблемы.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Конструктор класса обработка заявки.
        /// </summary>
        /// <param name="id">Идентификатор обработки заявки.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        /// <param name="ExecutorId">Идентификатор исполнителя.</param>
        public RequestProcessor(int id, int ClientId, int ExecutorId)
        {
            ID = id;
            Priority = string.Empty;
            ExecutorId = ExecutorId;
            Equipment = string.Empty;
            SerialNumber = string.Empty;
            Description = string.Empty;
            ClientId = ClientId;
        }
    }
    /// <summary>
    /// Класс исполнения заявки.
    /// </summary>
    public class RequestExecute
    {
        /// <summary>
        /// Идентификатор исполнения заявки.
        /// </summary>
        public int ID { get; private set;}
        /// <summary>
        /// Идентификатор исполнителя.
        /// </summary>
        public int ExecutorId { get; private set; }
        /// <summary>
        /// Тип оборудования.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNumber { get; private set; }
        /// <summary>
        /// Дата и время обновления заявки.
        /// </summary>
        public DateTime UpdateAt { get; private set; }
        /// <summary>
        /// Дата и время завершения заявки.
        /// </summary>
        public DateTime FinishAt { get; private set; }
        /// <summary>
        /// Статус заявки.
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// Конструктор класса исполнения заявки.
        /// </summary>
        /// <param name="id">Идентификатор исполнения заявки.</param>
        /// <param name="ExecutorId">Идентификатор исполнителя.</param>
        public RequestExecute(int id,int ExecutorId)
        {
            ID = id;
            ExecutorId = ExecutorId;
            Equipment = string.Empty;
            SerialNumber = string.Empty;
            UpdateAt = DateTime.Now;
            FinishAt = DateTime.MaxValue;
            Status = string.Empty;
        }
    }
    /// <summary>
    /// Класс отчетность.
    /// </summary>
    public class Report
    {
        /// <summary>
        /// Идентификатор отчетности.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Идентификатор исполнителя.
        /// </summary>
        public int ExecutorId { get; private set; }
        /// <summary>
        /// Тип оборудования.
        /// </summary>
        public string Equipment { get; private set; }
        /// <summary>
        /// Серийный номер оборудования.
        /// </summary>
        public string SerialNumber { get; private set; }
        /// <summary>
        /// Описание проблемы.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Описание выполненной работы.
        /// </summary>
        public string DescriptionExecute { get; private set; }
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ClientId { get; private set; }
        /// <summary>
        /// Приоритет заявки.
        /// </summary>
        public string Priority { get; private set; } 
        /// <summary>
        /// Дата и время создания заявки.
        /// </summary>
        public DateTime CreateAt { get; private set; }
        /// <summary>
        /// Дата и время завершения заявки.
        /// </summary>
        public DateTime FinishAt { get; private set; }
        /// <summary>
        /// Статус заявки.
        /// </summary>
        public string Status { get; private set; }
        /// <summary>
        /// Стоимость выполненной работы.
        /// </summary>
        public string Cost { get; private set; }
        /// <summary>
        /// Конструктор класса отчетность.
        /// </summary>
        /// <param name="id">Идентификатор отчетности.</param>
        /// <param name="ExecutorId">Идентификатор исполнителя.</param>
        /// <param name="ClientId">Идентификатор клиента.</param>
        public Report(int id, int ExecutorId, int ClientId)
        {
            ID = id;
            ExecutorId = ExecutorId;
            Equipment = string.Empty;
            SerialNumber = string.Empty;
            Description = string.Empty;
            DescriptionExecute = string.Empty;
            ClientId = ClientId;
            Priority = string.Empty;
            CreateAt = DateTime.MinValue;
            FinishAt = DateTime.MaxValue;
            Status = string.Empty;
            Cost = string.Empty;
        }

    }
    /// <summary>
    /// Класс мониторинг.
    /// </summary>
    public class Monitoring
    {
        /// <summary>
        /// Идентификатор мониторинга.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Дата и время создания заявки.
        /// </summary>
        public DateTime CreateAt { get; private set; }
        /// <summary>
        /// Дата и время завершения заявки.
        /// </summary>
        public DateTime FinishAt { get; private set; }
        /// <summary>
        /// Стоимость выполненной работы.
        /// </summary>
        public string Cost { get; private set; }
        /// <summary>
        /// Конструктор класса мониторинг.
        /// </summary>
        /// <param name="id">Идентификатор мониторинга.</param>
        public Monitoring(int id)
        {
            ID = id;
            CreateAt = DateTime.MinValue;
            FinishAt = DateTime.MaxValue;
            Cost = string.Empty;
        }
    }
    /// <summary>
    /// Класс клиент.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Фамилия клиента.
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// Имя клиента.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Телефон клиента.
        /// </summary>
        public string Phone { get; private set; }
        /// <summary>
        /// Почта клиента.
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// Конструктор класса клиент.
        /// </summary>
        /// <param name="id">Идентификатор клиента.</param>
        public Client(int id)
        {
            ID = id;
            Surname = string.Empty;
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
        }
    }
    /// <summary>
    /// Класс исполнитель.
    /// </summary>
    public class Executor
    {
        /// <summary>
        /// Идентификатор исполнителя.
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Фамилия исполнителя.
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// Имя исполнителя.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Номер телефона исполнителя.
        /// </summary>
        public string Phone { get; private set; }
        /// <summary>
        /// Почта исполнителя.
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// Должность исполнителя.
        /// </summary>
        public string Title { get; private set; }
        /// <summary>
        /// Конструктор класса исполнитель.
        /// </summary>
        /// <param name="id">Идентификатор исполнителя.</param>
        public Executor(int id)
        {
            ID = id;
            Surname = string.Empty;
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Title = string.Empty;
        }
    }
}
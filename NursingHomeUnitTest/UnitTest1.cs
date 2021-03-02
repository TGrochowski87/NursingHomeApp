using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NursingHomeApp;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Systems.LogicalManagers;

namespace NursingHomeUnitTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SelectTreatment_DataManager_ReturnsTrue()
        {
            var data = new List<Treatment>()
            {
                new Treatment{ Name= "SAUNA1",
                                Duration = new System.TimeSpan(00,30,00)},
                new Treatment{ Name= "SAUNA2",
                                Duration = new System.TimeSpan(01,30,00)},
                new Treatment{ Name= "SAUNA3",
                                Duration = new System.TimeSpan(00,45,00)},
            }.AsQueryable();

            var mockSet = new Mock<System.Data.Entity.DbSet<Treatment>>();
            mockSet.As<IQueryable<Treatment>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Treatment>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Treatment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Treatment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NursingHomeEntities>();
            mockContext.Setup(d => d.Treatments).Returns(mockSet.Object);
            var treatmentDataManager = new TreatmentDataManager(mockContext.Object);
            var treatments = treatmentDataManager.Select();

            Assert.AreEqual(3, treatments.Count);
            Assert.AreEqual("SAUNA1", treatments[0].Name);
            Assert.AreEqual("SAUNA2", treatments[1].Name);
            Assert.AreEqual("SAUNA3", treatments[2].Name);
            Assert.AreEqual(new System.TimeSpan(00, 30, 00), treatments[0].Duration);
            Assert.AreEqual(new System.TimeSpan(01, 30, 00), treatments[1].Duration);
            Assert.AreEqual(new System.TimeSpan(00, 45, 00), treatments[2].Duration);
        }

        [TestMethod]
        public void SelectTreatment_LogicalManager_ReturnsTrue()
        {
            var data = new List<Treatment>()
            {
                new Treatment{ Name= "SAUNA1",
                                Duration = new System.TimeSpan(00,30,00)},
                new Treatment{ Name= "SAUNA2",
                                Duration = new System.TimeSpan(01,30,00)},
                new Treatment{ Name= "SAUNA3",
                                Duration = new System.TimeSpan(00,45,00)},
            }.AsQueryable();

            var mockSet = new Mock<System.Data.Entity.DbSet<Treatment>>();
            mockSet.As<IQueryable<Treatment>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Treatment>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Treatment>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Treatment>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NursingHomeEntities>();
            mockContext.Setup(d => d.Treatments).Returns(mockSet.Object);
            var treatmentManager = new TreatmentManager();
            treatmentManager.TreatmentDataManager = new TreatmentDataManager(mockContext.Object);
            var treatments = treatmentManager.Select();

            Assert.AreEqual(3, treatments.Count);
            Assert.AreEqual("SAUNA1", treatments[0].Name);
            Assert.AreEqual("SAUNA2", treatments[1].Name);
            Assert.AreEqual("SAUNA3", treatments[2].Name);
            Assert.AreEqual(new System.TimeSpan(00, 30, 00), treatments[0].Duration);
            Assert.AreEqual(new System.TimeSpan(01, 30, 00), treatments[1].Duration);
            Assert.AreEqual(new System.TimeSpan(00, 45, 00), treatments[2].Duration);
        }        
        [TestMethod]
        public void SelectMedicine_DataManager_ReturnsTrue()
        {
            var data = new List<Medicine>()
            {
                new Medicine{ Name= "LEK1",
                                Amount = 3},
                new Medicine{ Name= "LEK2",
                                 Amount = 4},
                new Medicine{ Name= "LEK3",
                                 Amount = 5},
            }.AsQueryable();

            var mockSet = new Mock<System.Data.Entity.DbSet<Medicine>>();
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NursingHomeEntities>();
            mockContext.Setup(d => d.Medicines).Returns(mockSet.Object);
            var medicineDataManager = new MedicineDataManager(mockContext.Object);
            var medicine = medicineDataManager.Select();

            Assert.AreEqual(3, medicine.Count);
            Assert.AreEqual("LEK1", medicine[0].Name);
            Assert.AreEqual("LEK2", medicine[1].Name);
            Assert.AreEqual("LEK3", medicine[2].Name);
            Assert.AreEqual(3, medicine[0].Amount);
            Assert.AreEqual(4, medicine[1].Amount);
            Assert.AreEqual(5, medicine[2].Amount);
        }

        [TestMethod]
        public void SelectMedcine_LogicalManager_ReturnsTrue()
        {
            var data = new List<Medicine>()
            {
                new Medicine{ Name= "LEK1",
                                Amount = 3},
                new Medicine{ Name= "LEK2",
                                 Amount = 4},
                new Medicine{ Name= "LEK3",
                                 Amount = 5},
            }.AsQueryable();

            var mockSet = new Mock<System.Data.Entity.DbSet<Medicine>>();
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Medicine>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NursingHomeEntities>();
            mockContext.Setup(d => d.Medicines).Returns(mockSet.Object);
            var medicineManager = new MedicineManager();
            medicineManager.MedicineDataManager = new MedicineDataManager(mockContext.Object);
            var medicine = medicineManager.Select();


            Assert.AreEqual(3, medicine.Count);
            Assert.AreEqual("LEK1", medicine[0].Name);
            Assert.AreEqual("LEK2", medicine[1].Name);
            Assert.AreEqual("LEK3", medicine[2].Name);
            Assert.AreEqual(3, medicine[0].Amount);
            Assert.AreEqual(4, medicine[1].Amount);
            Assert.AreEqual(5, medicine[2].Amount);
        }

        [TestMethod]
        public void AddTreatment_DataManager_ReturnsTrue()
        {
            var exampleTreatment = new Treatment() { Name = "SAUNA1", Duration = new System.TimeSpan(00, 30, 00) };
            var mockSet = new Mock<System.Data.Entity.DbSet<Treatment>>();

            var mockContext = new Mock<NursingHomeEntities>();
            mockContext.Setup(d => d.Treatments.Add(It.IsAny<Treatment>())).Returns((Treatment t) => t);
            mockContext.Setup(d => d.SaveChanges()).Returns(1);

            var treatmentDataManager = new TreatmentDataManager(mockContext.Object);
            var treatment = treatmentDataManager.Add(exampleTreatment);

            mockContext.Verify(x => x.SaveChanges(), Times.Once);
            Assert.IsTrue(treatment);
        }

        [TestMethod]
        public void Add_Treatment_LogicalManager_ReturnsTrue()
        {
            var mockSet = new Mock<System.Data.Entity.DbSet<Treatment>>();

            var mockContext = new Mock<NursingHomeEntities>();
            mockContext.Setup(d => d.Treatments.Add(It.IsAny<Treatment>())).Returns((Treatment t) => t);
            mockContext.Setup(d => d.SaveChanges()).Returns(1);

            var treatmentManager = new TreatmentManager();
            treatmentManager.TreatmentDataManager = new TreatmentDataManager(mockContext.Object);
            var treatment = treatmentManager.Add("SAUNA1", new System.TimeSpan(00, 30, 00));

            mockContext.Verify(x => x.SaveChanges(), Times.Once);
            Assert.IsTrue(treatment);
        }

        [TestMethod]
        public void AddMedicine_LogicalManager_EmptyString_ReturnsFalse()
        {
            //var mockSet = new Mock<System.Data.Entity.DbSet<Medicine>>();

            //var mockContext = new Mock<NursingHomeEntities>();
            //mockContext.Setup(d=>d.Medicines.Add(It.IsAny<Medicine>())).Returns((Medicine t)=>t);
            //mockContext.Setup(d=>d.SaveChanges()).Returns(1);

            var medicineManager = new MedicineManager();
            //medicineManager.MedicineDataManager = new MedicineDataManager(mockContext.Object);

            var treatment = medicineManager.Add("", 5);

            Assert.IsFalse(treatment);
        }

        [TestMethod]
        public void AddMedicine_LogicalManager_ReturnsTrue()
        {
            var mockSet = new Mock<System.Data.Entity.DbSet<Medicine>>();

            var mockContext = new Mock<NursingHomeEntities>();
            mockContext.Setup(d => d.Medicines.Add(It.IsAny<Medicine>())).Returns((Medicine t) => t);
            mockContext.Setup(d => d.SaveChanges()).Returns(1);

            var medicineManager = new MedicineManager();
            medicineManager.MedicineDataManager = new MedicineDataManager(mockContext.Object);
            var medicine = medicineManager.Add("Rutinoscorbin", 5);

            Assert.IsTrue(medicine);
        }

        [TestMethod]
        public void AddRoom_LogicalManager_EmptyString_ReturnsFalse()
        {
            //var mockSet = new Mock<System.Data.Entity.DbSet<Room>>();

            //var mockContext = new Mock<NursingHomeEntities>();
            //mockContext.Setup(d => d.Rooms.Add(It.IsAny<Room>())).Returns((Room t) => t);
            //mockContext.Setup(d => d.SaveChanges()).Returns(1);

            var roomManager = new RoomManager();
            //roomManager.RoomDataManager = new RoomDataManager(mockContext.Object);

            var room = roomManager.Add(0);

            Assert.IsFalse(room);
        }

        [TestMethod]
        public void AddRoom_LogicalManager_ReturnsTrue()
        {
            var mockSet = new Mock<System.Data.Entity.DbSet<Room>>();

            var mockContext = new Mock<NursingHomeEntities>();
            mockContext.Setup(d => d.Rooms.Add(It.IsAny<Room>())).Returns((Room t) => t);
            mockContext.Setup(d => d.SaveChanges()).Returns(1);

            var roomManager = new RoomManager();
            roomManager.RoomDataManager = new RoomDataManager(mockContext.Object);

            var room = roomManager.Add(1);

            Assert.IsTrue(room);
        }
    }
}

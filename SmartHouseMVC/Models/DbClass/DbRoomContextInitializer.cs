using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SmartHouseMVC.Models.DbClass
{
    public class DbRoomContextInitializer : DropCreateDatabaseIfModelChanges<DbRoomContext>
    {
        protected override void Seed(DbRoomContext context)
        {
            DbRoom r1 = new DbRoom { Id = 1, Name = "overallfunctionality", LightinState = "MechanialSwitch", PowerState = "AlternativePower", BlindsState = "raised"};
            DbRoom r2 = new DbRoom { Id = 2, Name = "bathroom", FrostedGlassState = "off", DimmingGlass = 5, FloorHeating = "off", Boiler = "off", OzonationState = "off"};
            DbRoom r3 = new DbRoom { Id = 3, Name = "bedroom", FrostedGlassState="off", DimmingGlass=5, TempConditioning=20, ConditioningState="off", FloorHeating="off", OzonationState="off",HumidificationState="off" };
            DbRoom r4 = new DbRoom { Id = 4, Name = "childrensroom", FrostedGlassState = "off", DimmingGlass = 5, TempConditioning = 20, ConditioningState = "off", FloorHeating = "off", OzonationState = "off", HumidificationState = "off" };
            DbRoom r5 = new DbRoom { Id = 5, Name = "livingroom", FrostedGlassState = "off", DimmingGlass = 5, TempConditioning = 20, ConditioningState = "off", FloorHeating = "off", OzonationState = "off", HumidificationState = "off" };
            DbRoom r6 = new DbRoom { Id = 6, Name = "kitchen", FrostedGlassState = "off", DimmingGlass = 5, FloorHeating = "off", OzonationState = "off"};
            DbRoom r7 = new DbRoom { Id = 7, Name = "hall", FloorHeating = "off", OzonationState = "off"};
            User one = new User { Id = 1, Name = "Master", Password = "dbc4d84bfcfe2284ba11beffb853a8c4" };
            context.Users.Add(one);
            context.DbRooms.Add(r1);
            context.DbRooms.Add(r2);
            context.DbRooms.Add(r3);
            context.DbRooms.Add(r4);
            context.DbRooms.Add(r5);
            context.DbRooms.Add(r6);
            context.DbRooms.Add(r7);
            context.SaveChanges();
        }
    
    }
}
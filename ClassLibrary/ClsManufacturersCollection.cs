using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsManufacturersCollection
    {
        // Private data member for the list
        private List<ClsManufacturers> mManufacturersList = new List<ClsManufacturers>();
        // Private data member for ThisManufacturer
        private ClsManufacturers mThisManufacturer = new ClsManufacturers();

        // Public property for the ManufacturersList
        public List<ClsManufacturers> ManufacturersList
        {
            get { return mManufacturersList; }
            set { mManufacturersList = value; }
        }

        // Public property for Count
        public int Count
        {
            get { return mManufacturersList.Count; }
        }

        // Public property for ThisManufacturer
        public ClsManufacturers ThisManufacturer
        {
            get { return mThisManufacturer; }
            set { mThisManufacturer = value; }
        }

        // Constructor for the class
        public ClsManufacturersCollection()
        {
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure to get all manufacturers
            DB.Execute("sproc_tblManufacturers_SelectAll");
            // Populate the list with the data table
            PopulateArray(DB);
        }

        // Method to populate the list based on the data table in the parameter DB
        void PopulateArray(clsDataConnection DB)
        {
            // Populate the list based on the table in the database
            int Index = 0;
            int RecordCount = DB.Count;
            mManufacturersList = new List<ClsManufacturers>();
            while (Index < RecordCount)
            {
                ClsManufacturers AManufacturer = new ClsManufacturers();
                AManufacturer.ManufacturersId = Convert.ToInt32(DB.DataTable.Rows[Index]["ManufacturersId"]);
                AManufacturer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AManufacturer.Country = Convert.ToString(DB.DataTable.Rows[Index]["Country"]);
                AManufacturer.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["Is_active"]);
                AManufacturer.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[Index]["Created_at"]);
                mManufacturersList.Add(AManufacturer);
                Index++;
            }
        }

        public int Add()
        {
            // Add a new record to the database based on the values of mThisManufacturer
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisManufacturer.Name);
            DB.AddParameter("@Country", mThisManufacturer.Country);
            DB.AddParameter("@Is_active", mThisManufacturer.IsActive);
            DB.AddParameter("@Created_at", mThisManufacturer.CreatedAt);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblManufacturers_Insert");
        }

        public void Delete(int manufacturersId)
        {
            // Delete a record from the database based on the ManufacturersId
            clsDataConnection DB = new clsDataConnection();
            // Set the parameter for the stored procedure
            DB.AddParameter("@ManufacturersId", manufacturersId);
            // Execute the stored procedure
            DB.Execute("sproc_tblManufacturers_Delete");
        }

        public void Update()
        {
            // Update an existing record in the database based on the values of mThisManufacturer
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@ManufacturersId", mThisManufacturer.ManufacturersId);
            DB.AddParameter("@Name", mThisManufacturer.Name);
            DB.AddParameter("@Country", mThisManufacturer.Country);
            DB.AddParameter("@Is_active", mThisManufacturer.IsActive);
            DB.AddParameter("@Created_at", mThisManufacturer.CreatedAt);
            // Execute the stored procedure
            DB.Execute("sproc_tblManufacturers_Update");
        }
    }
}
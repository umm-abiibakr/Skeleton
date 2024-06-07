using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Data.Sql;

namespace ClassLibrary
{
    public class ClsManufacturers
    {
        // Private data members
        private int mManufacturersId;
        private string mName;
        private string mCountry;
        private bool mIsActive;
        private DateTime mCreatedAt;

        // Public properties
        public int ManufacturersId
        {
            get { return mManufacturersId; }
            set { mManufacturersId = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Country
        {
            get { return mCountry; }
            set { mCountry = value; }
        }

        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        public DateTime CreatedAt
        {
            get { return mCreatedAt; }
            set { mCreatedAt = value; }
        }

        // Find method for manufacturer by ManufacturersId
        public bool Find(int manufacturersId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ManufacturersId", manufacturersId);
            DB.Execute("sproc_tblManufacturers_FindByManufacturersId");

            if (DB.Count == 1)
            {
                mManufacturersId = Convert.ToInt32(DB.DataTable.Rows[0]["ManufacturersId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mCountry = Convert.ToString(DB.DataTable.Rows[0]["Country"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Is_active"]);
                mCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["Created_at"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Valid method
        public string Valid(string name, string country, string isActive, string createdAt)
        {
            // Create a string variable to store the error
            string Error = "";

            // Validation rules

            // Name cannot be blank
            if (string.IsNullOrWhiteSpace(name))
            {
                Error += "The name may not be blank. ";
            }

            // Country cannot be blank
            if (string.IsNullOrWhiteSpace(country))
            {
                Error += "The country may not be blank. ";
            }

            // IsActive must be either 'true' or 'false'
            bool isActiveBool;
            if (!bool.TryParse(isActive, out isActiveBool))
            {
                Error += "The active status must be either 'true' or 'false'. ";
            }

            // CreatedAt must be a valid date
            DateTime createdAtTemp;
            if (!DateTime.TryParse(createdAt, out createdAtTemp))
            {
                Error += "The created date is not a valid date. ";
            }

            // Return any error messages
            return Error;
        }
    }
}
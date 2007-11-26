//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//	   DO NOT MODIFY contents of this file. Changes to this
//	   file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using WilsonORWrapper;
using WilsonORWrapper.Entities;
using Wilson.ORMapper;

namespace UserApp.Entities
{
	#region Department
	[Serializable,DataObject(true)]
    public partial class Department : EntityBase<Department>, IObjectHelper
	{
		#region Properties

		private int _departmentid;
		///<summary>Database mapping to column departments.departmentid</summary>
		[DataObjectField(true, true)]
		public int Departmentid
		{
			get { return _departmentid; }
		}
		
		private string _departmentMember;
		///<summary>Database mapping to column departments.department</summary>
		public string DepartmentMember
		{
			get { return _departmentMember; }
			set { _departmentMember = value; }
		}
		
		private int _managerUserid;
		///<summary>Database mapping to column departments.manager_userid</summary>
		public int ManagerUserid
		{
			get { return _managerUserid; }
			set { _managerUserid = value; }
		}
		
		private ObjectHolder<User> _managerUser;
		///<summary>Instance of a User object</summary>
		public User ManagerUser
		{
			get { return _managerUser.InnerObject; }
			set { _managerUser.InnerObject = value; }
		}
		
		private IList<User> _users;
		///<summary>Collection of User objects</summary>
		public IList<User> Users
		{
			get { return _users; }
		}
		
		#endregion
		
		///<summary>Initializes a new instance of this class</summary>
		public Department() : base()
		{
			// Default Constructor
		}

		#region System.Object
		/// <summary>
		/// Returns the hash code for this entity, 
		/// based on the primary key identity fields of the underlying object.
		/// </summary>
		public override int GetHashCode()
		{
			string hashstring = _departmentid.GetHashCode().ToString();
			int hashcode;
			while ( int.TryParse(hashstring, out hashcode) == false )
				hashcode = hashcode / 11;
			
			return hashcode;
		}
		/// <summary>
		/// Returns a formatted string that includes key fields of this entity.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return String.Format("{0}", _departmentid.ToString());
		}
		#endregion
		
		public override IIdentity GetIdentity()
		{
			return new DepartmentIdentity(_departmentid);
		}

		#region IObjectHelper
		/// <summary>Indexer to update local member variables</summary>	
		/// <remarks>This indexer is used by the Wilson WilsonORWrapper</remarks>
		object IObjectHelper.this[string memberName]
		{
			get {
				switch (memberName) {
					case "_departmentid": return _departmentid;
					case "_departmentMember": return _departmentMember;
					case "_managerUserid": return _managerUserid;
					case "_managerUser": return _managerUser;
					case "_users": return _users;
									
					default: throw new Exception(string.Format("Mapping: IObjectHelper Get is missing member case {0}", memberName));
				}
			}
			set {
				//handle null values
				if(value == null)
					return;
					
				switch (memberName) {
					case "_departmentid": _departmentid = (int)value; break;
					case "_departmentMember": _departmentMember = (string)value; break;
					case "_managerUserid": _managerUserid = (int)value; break;
					case "_managerUser": _managerUser = (ObjectHolder<User>)value; break;
					case "_users": _users = (IList<User>)value; break;
				
					default: throw new Exception(string.Format("Mapping: IObjectHelper Set is missing member case {0}", memberName));
				}
			}
		}
		#endregion
	}
	#endregion
	
	#region DepartmentIdentity
	public class DepartmentIdentity : IdentityBase
	{
		public readonly int Departmentid;

		private readonly string[] IDENTITY_KEYS = new string[] { "Department.Departmentid" };

		public DepartmentIdentity(int departmentid)
		{
			this.Departmentid = departmentid;

		}
		public override string[] Keys
		{
			get { return IDENTITY_KEYS; }
		}
		public override DictionaryEntry[] GetIdentityEntries()
		{
			DictionaryEntry[] entries = new DictionaryEntry[1]; 
			entries[0] = new DictionaryEntry("Department.Departmentid", Departmentid); 

			return entries;
		}
	}
	#endregion
}
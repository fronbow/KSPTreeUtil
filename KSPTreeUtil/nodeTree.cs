using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPTreeUtil
{
    public class nodeTree
    {
    	private string _name;
        public string name {
    		get {
    			return _name;
    		}
    		set {
    			_name = value;
    		}
    	}
		private string _techID;
    	
		public string TechID {
			get { return _techID; }
			set { _techID = value; }
		}
		private string _pos;
    	
		public string Pos {
			get { return _pos; }
			set { _pos = value; }
		}
		private string _icon;
    	
		public string Icon {
			get { return _icon; }
			set { _icon = value; }
		}
		private int _cost;
    	
		public int Cost {
			get { return _cost; }
			set { _cost = value; }
		}
		private string _title;
    	
		public string Title {
			get { return _title; }
			set { _title = value; }
		}
		private string _description;
    	
		public string Description {
			get { return _description; }
			set { _description = value; }
		}
		private bool _anyParent;
    	
		public bool AnyParent {
			get { return _anyParent; }
			set { _anyParent = value; }
		}
		private bool _hideIfEmpty;
    	
		public bool HideIfEmpty {
			get { return _hideIfEmpty; }
			set { _hideIfEmpty = value; }
		}
		private string _parents;
    	
		public string Parents {
			get { return _parents; }
			set { _parents = value; }
		}
		
		//private _parts parts;
        public List<string> Parts = new List<string>();

        public nodeTree()
        {
            //initialise
            name = "";
            TechID = "";
            Pos = "";
            Icon = "";
            Cost = 0;
            Title = "";
            Description = "";
            AnyParent = false;
            HideIfEmpty = false;
            Parents = "";


        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string getString( string s )
        {
            if (s == "name")
            {
                return _name;
            }

            return "";
        }

        public nodeTree Copy()
        {
            return (nodeTree)this.MemberwiseClone();
        }
    }
    

}

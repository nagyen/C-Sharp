//helper to get nested property
        public static PropertyInfo GetProp<T>(String name)
            where T:new()
        {
            PropertyInfo info = null;
            Type type = typeof(T);
            foreach (String part in name.Split('.'))
            {
                info = type.GetProperty(part);
                if (info == null) { return null; }
                type = info.PropertyType;
            }
            return info;
        }

namespace Project_App
{
    public class Statistics
    {
        private List<float> activities = new List<float>();
        public void AddActivity(float walkingTime)
        {
            this.activities.Add(walkingTime);
        }
        public void AddActivity2(float trainingTime)
        { 
            this.activities.Add(trainingTime); 
        }
        public void AddActivity3(float cuddlingTime)
        { 
            this.activities.Add(cuddlingTime); 
        }
        public void AddActivity4(float otherActivity)
        { 
            this.activities.Add(otherActivity); 
        }
    }
}

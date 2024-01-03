namespace Project_App
{
    public class Activities
    {
        public List<float> activities = new List<float>();
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
        public float CalculateTotalActiveTime()
        {
            float totalActiveTime = this.activities.Sum();
            return totalActiveTime;
        }
        public float CalculateRestingTime()
        {
            float totalActiveTime = CalculateTotalActiveTime();
            float RestingTime = 24 - (totalActiveTime / 60);
            return RestingTime;
        }
    }
}

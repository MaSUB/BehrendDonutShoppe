namespace _421FinalProject.Orders {
    interface DonutIF : Item
    {
        string description();
        int getCalories();
        bool isGlazed();
        bool isIced();
    }
}

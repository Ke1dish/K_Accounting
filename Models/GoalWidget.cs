// K_Accounting/Widgets/GoalWidgetModel.cs
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace K_Accounting.Widgets
{
    public class GoalWidget
    {
        public List<GoalProgress> TopGoals { get; set; } = new List<GoalProgress>();
        public Goal NearestGoal { get; set; }

        public class GoalProgress
        {
            public Goal Goal { get; set; }
            public decimal ProgressPercent { get; set; }
        }

        public static GoalWidget GetData()
        {
            using var db = new AppDbContext();

            var model = new GoalWidget();

            // Получаем все активные цели
            var goals = db.Goals
                .Where(g => g.Status == GoalStatus.Active && !g.IsDeleted)
                .ToList();

            // Рассчитываем прогресс
            var goalsWithProgress = goals.Select(g => new GoalProgress
            {
                Goal = g,
                ProgressPercent = g.TargetAmount != 0
                    ? Math.Round(g.CurrentAmount / g.TargetAmount * 100, 1)
                    : 0
            }).ToList();

            // Топ-3 по прогрессу
            model.TopGoals = goalsWithProgress
                .OrderByDescending(g => g.ProgressPercent)
                .Take(3)
                .ToList();

            // Ближайшая цель
            model.NearestGoal = goals
                .Where(g => g.TargetDate >= DateTime.Today)
                .OrderBy(g => g.TargetDate)
                .FirstOrDefault();

            return model;
        }
    }
}
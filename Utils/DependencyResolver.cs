using Data;
using Logic;

namespace Utils
{
    public class DependencyResolver
    {
        private static IFiguresRepository figuresRepository;
        private static IFiguresLogic figuresLogic;

        public static IFiguresRepository FiguresRepository
        {
            get => figuresRepository ??= new FiguresRepository();
        }

        public static IFiguresLogic FiguresLogic
        {
            get => figuresLogic ??= new FiguresLogic(FiguresRepository);
        }
    }
}

using Autofac;
using System;
using ThreeSixPlayground.Services.Navigation;
using ThreeSixPlayground.ViewModels.Visual;

namespace ThreeSixPlayground.ViewModels.Base
{
    public class Locator
    {
        private IContainer _container;
        private ContainerBuilder _containerBuilder;

        public static Locator Instance { get; } = new Locator();

        public Locator()
        {
            _containerBuilder = new ContainerBuilder();

            _containerBuilder.RegisterType<NavigationService>().As<INavigationService>();

            _containerBuilder.RegisterType<ActivityIndicatorViewModel>();
            _containerBuilder.RegisterType<ButtonViewModel>();
            _containerBuilder.RegisterType<CardViewModel>();
            _containerBuilder.RegisterType<EditorViewModel>();
            _containerBuilder.RegisterType<EntryViewModel>();
            _containerBuilder.RegisterType<PickerViewModel>();
            _containerBuilder.RegisterType<ProgressViewModel>();
            _containerBuilder.RegisterType<SliderViewModel>();
            _containerBuilder.RegisterType<StepperViewModel>();

            _containerBuilder.RegisterType<FontIconSourceViewModel>();
            _containerBuilder.RegisterType<MainViewModel>();
            _containerBuilder.RegisterType<PinsSourceViewModel>();
            _containerBuilder.RegisterType<ReadOnlyEntryViewModel>();
            _containerBuilder.RegisterType<VisualViewModel>();

            if (_container != null)
            {
                _container.Dispose();
            }

            _container = _containerBuilder.Build();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            _containerBuilder.RegisterType<TImplementation>().As<TInterface>();
        }

        public void Register<T>() where T : class
        {
            _containerBuilder.RegisterType<T>();
        }

        public void Build()
        {
            _container = _containerBuilder.Build();
        }
    }
}
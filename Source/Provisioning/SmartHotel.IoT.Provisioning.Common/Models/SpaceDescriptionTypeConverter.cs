using System;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace SmartHotel.IoT.Provisioning.Common.Models
{
    public class SpaceDescriptionTypeConverter : IYamlTypeConverter
    {
	    public bool Accepts(Type type)
	    {
		    return type == typeof(SpaceDescription);
	    }

	    public object ReadYaml(IParser parser, Type type)
	    {
		    throw new NotImplementedException();
	    }

	    public void WriteYaml(IEmitter emitter, object value, Type type)
	    {
		    if (!(value is SpaceDescription sd))
		    {
			    return;
		    }

		    emitter.Emit(new Scalar(nameof(SpaceDescription.name), sd.name));
	    }
    }
}

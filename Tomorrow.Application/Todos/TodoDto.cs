using System;
using Tomorrow.DomainModel;
using Tomorrow.DomainModel.Groups;

namespace Tomorrow.Application.Todos
{
	public record TodoDto(Guid Id, string Name, int Priority, bool Completed, Guid? GroupId)
	{
		public TodoDto(Guid id, string name, int priority, bool completed, Identifier<Group>? groupId) : this(id, name, priority, completed, groupId?.ToGuid())
		{
		}
	}
}

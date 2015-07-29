//if you want to distinct a list of Object on ONE or MORE Properties of the object
//You want to group them and pick a winner out of the group.

List<Person> distinctPeople = allPeople
  .GroupBy(p => p.PersonId)
  .Select(g => g.First())
  .ToList();


//If you want to define groups on multiple properties, here's how:

List<Person> distinctPeople = allPeople
  .GroupBy(p => new {p.PersonId, p.FavoriteColor} )
  .Select(g => g.First())
  .ToList();

vm.deletePerson = function (person) {
    abp.message.confirm(
        app.localize('AreYouSureToDeletePerson', person.name),
        function (isConfirmed) {
            if (isConfirmed) {
                personService.deletePerson({
                    id: person.id
                }).then(function () {
                    abp.notify.success(app.localize('SuccessfullyDeleted'));
                    getPeople();
                });
            }
        }
    );
};

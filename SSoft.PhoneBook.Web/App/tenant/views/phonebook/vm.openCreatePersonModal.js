(function() {
    appModule.controller('tenant.views.phonebook.index', [
        '$scope', '$uibModal', 'abp.services.app.person',
        function ($scope, $uibModal, personService) {
            var vm = this;

            vm.persons = [];

            function getPeople() {
                personService.getPeople({}).then(function (result) {
                    vm.persons = result.data.items;
                });
            }
            
            vm.openCreatePersonModal = function () {
                var modalInstance = $uibModal.open({
                    templateUrl: '~/App/tenant/views/phonebook/createPersonModal.cshtml',
                    controller: 'tenant.views.phonebook.createPersonModal as vm',
                    backdrop: 'static'
                });

                modalInstance.result.then(function () {
                    getPeople();
                });
            };
            vm.permissions = {
                createPerson: abp.auth.hasPermission('Pages.Tenant.PhoneBook.CreatePerson')
            };
            getPeople();
        }
    ]);
})();
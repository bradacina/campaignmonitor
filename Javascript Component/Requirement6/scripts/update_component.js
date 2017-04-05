
Vue.component('update',{
    props: [
        'item'
    ],
    template:
    `<div class="update-template">
        <p>Update</p>
        <em>By {{item.by}} {{timeFromNow(item.at)}} ago</em>
        <hr style="width:50%"/>
    </div>`,
    methods: {
        timeFromNow: function(unparsedDate) {
            if (unparsedDate) {
                var date = moment(unparsedDate, dateFormat);
                if (date.isValid()) {
                    return date.fromNow();
                }
            }

            return "at an unknown time";
        },

        by: function() {
            if (this.item && this.item.by) {
                return this.item.by;
            }

            return "Unknown Person";
        }
    }
});
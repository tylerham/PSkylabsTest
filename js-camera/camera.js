
$(function(){

  var Image = Backbone.Model.extend({

    defaults: function() {
      return {
        uri: '/img/placeholder.jpg',
        previous: 'prev-id',
        next: 'next-id'
      };
    }

  });

  var CameraList = Backbone.Collection.extend({
    model: Image
  });

  var Cameras = new CameraList;

  var ImageView = Backbone.View.extend({

    tagName:  "div",

    template: _.template($('#image-template').html()),

    // The DOM events specific to an item.
    events: {
      "click a.previous"   : "previous",
      "click a.next"  : "next"
    },

    initialize: function() {
      this.listenTo(this.model, 'change', this.render);
      this.render();
    },

    render: function() {
      this.$el.html(this.template(this.model.toJSON()));
      return this;
    },

    previous: function() {

    },
    next: function() {

    }

  });

});